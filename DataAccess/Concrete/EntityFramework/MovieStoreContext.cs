using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class MovieStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MovieStore;Trusted_Connection=true");
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
