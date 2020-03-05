using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FloChar.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FloChar
{
    [Authorize]
    public class AskQuestionModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }

        public AskQuestionModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
    }
}