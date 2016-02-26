using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductManager.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is Required!!!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{5,15}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
    }
}