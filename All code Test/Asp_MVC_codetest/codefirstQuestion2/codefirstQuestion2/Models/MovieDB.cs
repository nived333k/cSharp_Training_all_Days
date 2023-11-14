using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codefirstQuestion2.Models
{
    public class MovieDB
    {
        [Key]
        public int Mid { get; set; }
        public string MovieName { get; set; }
        public string MovieDate { get; set; }
    }
}