using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloChar.Models
{
    public class UserQuestionAnswerSet
    {
        public RootQuestion RootQuestion { get; set; }
        public List<AnsweredSubQuestion> AnsweredSubQuestions { get; set; }

        public class AnsweredSubQuestion
        {
            public SubQuestion SubQuestion { get; set; }
            public List<Answer> Answers { get; set; }
        }
    }

    public class AskedQuestions
    {
        public string RootQuestionName { get; set; }
        public List<string> SubQuestionNames { get; set; }
    }
}
