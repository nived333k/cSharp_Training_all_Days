using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace datafirst.Models
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<movies> Movies { get; set; }
    }
}