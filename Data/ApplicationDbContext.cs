using System;
using System.Collections.Generic;
using System.Text;
using FloChar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FloChar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RootQuestion> RootQuestions { get; set; }
        public DbSet<SubQuestion> SubQuestions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
