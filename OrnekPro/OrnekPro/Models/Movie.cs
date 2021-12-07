using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage ="Film Başlığı boş geçilmez")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Başlık 5 ile 50 karekter arasında olmalıdır")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Film Açıklaması boş geçilemez")]
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Player { get; set; }
        [Required]
        public string ImageUrl  { get; set; }

        [Required]
        public int?  TurId { get; set; }
    }
}
