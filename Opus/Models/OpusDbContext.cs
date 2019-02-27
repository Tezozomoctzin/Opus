using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Opus.Models
{
    public class OpusDbContext : DbContext
    {

        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FinancialStability> FinancialStability { get; set; }

        public OpusDbContext()
        {

        }
    }
}