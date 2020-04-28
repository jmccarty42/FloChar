using System;
using System.Collections.Generic;
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

            foreach(string subQuestion in askedQuestions.SubQuestionNames)
            {
                _context.SubQuestions.Add(new SubQuestion
                {
                    Name = subQuestion,
                    RootId = rootQuestion.Id
                });
            }

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost("answer/{rootid}/{id}/{value}")]
        public IActionResult PostUserAnswer(int rootid, int id, string value)
        {
            _context.Answers.Add(new Answer{ QuestionId = id, Value = value });

            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("api/tree/{rootId}")]
        public IActionResult GetTreeJson(int rootId)
        {
            UserQuestionAnswerSet uqas = GetUserQuestionsById(rootId).Value;
            string csvHeader = "";
            List<List<string> > answers = new List<List<string> >();
            int counter = 0;
            foreach (AnsweredSubQuestion asq in uqas.AnsweredSubQuestions)
            {
                csvHeader += asq.SubQuestion.Name+",";
                foreach (Answer ans in asq.Answers)
                {
                    answers[counter].Add(ans.)
                }
                counter++;
            }
            csvHeader.Remove(csvHeader.LastIndexOf(","));


            String command = @"python wwwroot/lib/dtl_algorithm/DecisionTree.py -f wwwroot/lib/dtl_algorithm/test_data.csv -o wwwroot/lib/dtl_algorithm/treeData.json";
            ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            cmdsi.Arguments = command;
            Process cmd = Process.Start(cmdsi);
            cmd.WaitForExit()
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
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