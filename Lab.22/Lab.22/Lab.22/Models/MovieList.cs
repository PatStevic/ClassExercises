using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab._22.Models
{
    public class MovieList
    {
        [Required]
        public string MovieName { get; set; }
    }
}
