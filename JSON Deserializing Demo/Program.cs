 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using JSON_Deserializing_Demo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON_Deserializing_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var url = "https://localhost:5001/api/Product"; // Calls the GetProduct() method and passes in the id: 8
            var productJsonString = client.GetStringAsync(url).Result; 
            var myProducts = JsonConvert.DeserializeObject<List<Product>>(productJsonString);

            foreach (var item in myProducts)
            {
                Console.WriteLine(item.ProductID);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.CategoryID);
                Console.WriteLine(item.OnSale);
                Console.WriteLine(item.StockLevel);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
