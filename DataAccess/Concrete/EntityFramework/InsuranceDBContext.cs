using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class InsuranceDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=Insurance;Trusted_Connection=true");

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Hospital> hospital { get; set; }
        public DbSet<City> city { get; set; }
        public DbSet<District> district { get; set; }
        public DbSet<Policy> policy { get; set; }
        public DbSet<Coverage> coverage { get; set; }
        public DbSet<PolicyCoverage> policyCoverage { get; set; }

        public DbSet<Payment> payment { get; set; }

    }
}
