﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace KusumlataBooks.Models
{
    
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CoverType name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}