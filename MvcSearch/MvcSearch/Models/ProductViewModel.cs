﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSearch.Models
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Price in AMD")]
        public decimal Price { get; set; }
    }
}