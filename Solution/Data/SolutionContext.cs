using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solution.Models;

namespace Solution.Data
{
    public class SolutionContext : DbContext
    {
        public SolutionContext (DbContextOptions<SolutionContext> options)
            : base(options)
        {
        }

        public DbSet<Solution.Models.Movie> Movie { get; set; }
    }
}
