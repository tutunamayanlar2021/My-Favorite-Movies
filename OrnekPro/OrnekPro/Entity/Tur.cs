﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Entity
{
    public class Tur
    {  [Key]
        public int TurId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
