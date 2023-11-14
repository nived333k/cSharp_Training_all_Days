using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codefirstQuestion2.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieDB> movies { get; set; }
    }
}