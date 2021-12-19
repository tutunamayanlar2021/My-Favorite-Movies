using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Entity
{
   
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int? TurId { get; set; }
    }
}
