using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace RestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();
            Console.ReadKey();
        }

        static async void DoWork()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:49092/api1/v1");
            if(response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Product>>(json);
                Console.WriteLine(json);
                foreach (var item in list)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    public class Product
    {
        public string Id { get; set; }
        [JsonProperty(PropertyName = "Full Name")]
        public string Name { get; set; }
        public string Categorie { get; set; }
    }
}
