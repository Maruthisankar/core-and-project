using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_project.Models;

namespace Final_project.Data
{
    public class Final_projectContext : DbContext
    {
        public Final_projectContext (DbContextOptions<Final_projectContext> options)
            : base(options)
        {
        }

        public DbSet<Final_project.Models.Product> Product { get; set; }
    }
}
