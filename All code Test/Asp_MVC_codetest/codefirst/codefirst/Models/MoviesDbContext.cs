using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codefirst.Models 
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<movies> Movie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<movies>().HasKey(m => m.Mid);
            base.OnModelCreating(modelBuilder);
        }
    }
}