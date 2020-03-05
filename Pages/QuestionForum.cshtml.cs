using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FloChar.Data;
using FloChar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FloChar
{
    [Authorize]
    public class QuestionForumModel : PageModel
    {
        private ApplicationDbContext _context;
        public QuestionForumModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<RootQuestion> RootQuestions { get; set; }

        public void OnGet()
        {
            RootQuestions = _context.RootQuestions.OrderByDescending(x => x.Id).Take(100).ToList();
        }
    }
}