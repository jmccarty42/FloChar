using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FloChar.Data;
using FloChar.Models;
using Microsoft.AspNetCore.Mvc;
using static FloChar.Models.UserQuestionAnswerSet;

namespace FloChar.Controllers
{
    [Route("/api/[controller]")]
    public class QuestionController : Controller
    {
        public static bool locked = false;
        public ApplicationDbContext _context;
        public QuestionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{rootId}")]
        public ActionResult<UserQuestionAnswerSet> GetUserQuestionsById(int rootId)
        {
            RootQuestion rootQuestion = _context.RootQuestions.Find(rootId);
            List<SubQuestion> subQuestions = _context.SubQuestions.Where(x => x.RootId == rootId).ToList();
            List<AnsweredSubQuestion> answeredSubQuestions = new List<AnsweredSubQuestion>();

            if(rootQuestion == null)
            {
                return NotFound(rootQuestion);
            }

            if(subQuestions == null)
            {
                return NotFound(subQuestions);
            }

            foreach (SubQuestion subQuestion in subQuestions)
            {
                answeredSubQuestions.Add(new AnsweredSubQuestion
                {
                    SubQuestion = subQuestion,
                    Answers = _context.Answers.Where(x => x.QuestionId == subQuestion.Id).ToList()
                });
            }

            return new UserQuestionAnswerSet
            {
                RootQuestion = rootQuestion,
                AnsweredSubQuestions = answeredSubQuestions
            };
        }

        [HttpPost("add")]
        //[Route("api/Question/add")]
        public IActionResult PostUserQuestion([FromBody] AskedQuestions askedQuestions)
        {
            RootQuestion rootQuestion = new RootQuestion
            {
                Name = askedQuestions.RootQuestionName,
                UserId = "Implement Me"
            };

            _context.RootQuestions.Add(rootQuestion);
            _context.SaveChanges();
            var csv = "";

            foreach (string subQuestion in askedQuestions.SubQuestionNames)
            {
                _context.SubQuestions.Add(new SubQuestion
                {
                    Name = subQuestion,
                    RootId = rootQuestion.Id
                });
            }

            _context.SaveChanges();

            write_csv(rootQuestion.Id);

            return NoContent();
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

        private void write_csv(int rootId)
        {
            UserQuestionAnswerSet uqas = GetUserQuestionsById(rootId).Value;
            string csvHeader = "";
            List<List<string>> answers = new List<List<string>>();
            int counter = 0;
            foreach (AnsweredSubQuestion asq in uqas.AnsweredSubQuestions)
            {
                csvHeader += asq.SubQuestion.Name + ",";
                answers.Add(new List<string>());
                foreach (Answer ans in asq.Answers)
                {
                    answers[counter].Add(ans.Value ? "Yes" : "No");
                }
                counter++;
            }
            csvHeader = csvHeader.Remove(csvHeader.LastIndexOf(','));
            List<string> answer_rows = new List<string>();

            int minindex = 0;
            int minval = answers[0].Count;
            for(int i = 0; i <answers.Count; i++)
            {
                if (answers[i].Count < minval)
                {
                    minindex = i;
                }
            }

            for (int i = 0; i < answers[minindex].Count; i++)
            {
                string line = "";
                foreach (List<string> answerSet in answers)
                {
                    line += answerSet[i] + ",";
                }
                line = line.Remove(line.LastIndexOf(","));
                answer_rows.Add(line);
            }
            

            string path = @"wwwroot/lib/dtl_algorithm/data_"+rootId + ".csv";
            // This text is added only once to the file.
            //if (System.IO.File.Exists(path))
            //{
            //    using (StreamWriter sw = System.IO.File.CreateText(path))
            //    {
            //        sw.WriteLine(csvHeader);
            //    }
            //}

            // Create a file to write to.
            while(locked){

            }
            locked = true;
            using (StreamWriter sw = System.IO.File.CreateText(path))
            {
                sw.WriteLine(csvHeader);
            }

            using (StreamWriter sw = System.IO.File.AppendText(path))
            {
                foreach (string row in answer_rows)
                {
                    sw.WriteLine(row);
                }
            }
            locked = false;
        }


        [HttpPost("answer/{rootid}/{id}/{value}")]
        public IActionResult PostUserAnswer(int rootid, int id, string value)
        {
            Console.WriteLine(rootid);
            _context.Answers.Add(new Answer{ QuestionId = id, Value = (value == "Yes"? true : false) });

            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("tree/{rootId}")]
        public ActionResult<string> GetTreeJson(int rootId)
        {   
            return Content(System.IO.File.ReadAllText(@"wwwroot/lib/dtl_algorithm/tree_"+rootId + ".json"));
        }

        public string run_cmd(string cmd, List<string> args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\rober\AppData\Local\Programs\Python\Python38-32\python ";
            string argument = " \"" + cmd + "\"";
            foreach (string arg in args){
                argument += " \"" + arg + "\"";
            }
            start.Arguments = argument;
            start.UseShellExecute = false;// Do not use OS shell
            start.CreateNoWindow = true; // We don't need new window
            start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
            start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
            using (Process process = Process.Start(start))
            {
                Debug.WriteLine("running");
                //process.WaitForExit();
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")
                    Debug.WriteLine(stderr);
                    Debug.WriteLine(result);
                }
            }
            return "";
        }



        [HttpPost("update/{rootId}")]
        public IActionResult UpdateGraph(int rootId)
        {
            write_csv(rootId);
            while (locked)
            {

            }
            locked = true;
            Debug.WriteLine("Calling python!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Debug.WriteLine(run_cmd("wwwroot/lib/dtl_algorithm/DecisionTree.py ", new List<string> { "wwwroot/lib/dtl_algorithm/data_" + rootId + ".csv ", rootId.ToString()}));
            locked = false;
            return NoContent();
        }

        public IActionResult DeleteUserQuestionByUQAS([FromBody] UserQuestionAnswerSet q)
        {
            foreach (AnsweredSubQuestion asq in q.AnsweredSubQuestions)
            {
                foreach (Answer a in asq.Answers)
                {
                    _context.Answers.Remove(a);
                }
                _context.SubQuestions.Remove(asq.SubQuestion);
            }

            _context.RootQuestions.Remove(q.RootQuestion);

            _context.SaveChanges();

            return NoContent();
        }
        [HttpPost("delete/{rootId}")]
        //[Route("api/Question/delete")]
        public IActionResult DeleteUserQuestionByRoot(int rootId)
        {
            
            DeleteUserQuestionByUQAS(GetUserQuestionsById(rootId).Value);

            return NoContent();
        }

        //public string GetDTLByRoot(RootQuestion root)
        //{

        //}
    }
}