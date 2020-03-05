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

        [HttpPost]
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
    }
}