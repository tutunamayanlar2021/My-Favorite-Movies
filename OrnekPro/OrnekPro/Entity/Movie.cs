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
        [Required(ErrorMessage = "title boş geçilemez")]
        [MaxLength(500)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }

        
        [Required(ErrorMessage = "Kategori boş geçilemez")]
        public int? TurId { get; set; }
    }
}
