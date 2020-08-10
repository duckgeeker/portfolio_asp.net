using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models 
{
    public class PortfolioContext : DbContext
    {
        public DbSet<Work> Works { get; set; }
        public DbSet<Order> Orders { get; set; }

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
