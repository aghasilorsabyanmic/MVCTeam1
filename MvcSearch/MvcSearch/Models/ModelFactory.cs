using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSearch.Models
{
    public class ModelFactory
    {
        public static IEnumerable<ProductViewModel> GetProducts()
        {
            var result = Enumerable.Range(1, 100).Select(n => new ProductViewModel {
                Name = $"Product {n}",
                Price = n * 10
            });

            return result;
        }
    }
}