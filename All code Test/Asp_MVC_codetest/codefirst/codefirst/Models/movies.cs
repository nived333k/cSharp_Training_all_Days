using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace codefirst.Models
{
    public class movies
    {
        [Key]
        public int Mid { get; set; }

        [Required]
        public string Moviename { get; set; }

        [Required]
        public DateTime DateofRelease { get; set; }
    }
}