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
            var url = "https://localhost:5001/api/Product/8"; // Calls the GetProduct() method and passes in the id: 8

            Product myProduct = JsonConvert.DeserializeObject<Product>(client.GetStringAsync(url).Result);

            Console.WriteLine(myProduct.ProductID);
            Console.WriteLine(myProduct.Name);
            Console.WriteLine(myProduct.Price);
            Console.WriteLine(myProduct.CategoryID);
            Console.WriteLine(myProduct.OnSale);
            Console.WriteLine(myProduct.StockLevel);
        }

    }
}
