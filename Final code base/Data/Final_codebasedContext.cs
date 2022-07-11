using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_codebased.Models;

namespace Final_codebased.Data
{
    public class Final_codebasedContext : DbContext
    {
        public Final_codebasedContext (DbContextOptions<Final_codebasedContext> options)
            : base(options)
        {
        }

        public DbSet<Final_codebased.Models.Employee> Employee { get; set; }
    }
}
