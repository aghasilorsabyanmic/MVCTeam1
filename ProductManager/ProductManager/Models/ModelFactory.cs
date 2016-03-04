using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.Models
{
    public class ModelFactory
    {
        public static Category Create(CategoryViewModel model)
        {
            return new Category
            {
                Id = model.Id,
                Name = model.Name,
            };
        }

        public static ProductResponseModel Create(Product model)
        {
            return new ProductResponseModel
            {
                Id = model.Id,
                Name = model.Name,
                Categorie = model.Category.Name
            };
        }
    }

    public class ProductResponseModel
    {
        public string Id { get; set; }
        [JsonProperty(PropertyName = "Full Name")]
        public string Name { get; set; }
        public string Categorie { get; set; }
    }
}