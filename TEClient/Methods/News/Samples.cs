using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TEClient;

namespace CSharpExamples
{
    class News
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();
            
            // get lastest news
            Console.WriteLine("**********Get lastest news**********");
            var res1 = client.News.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get lastest news by country, or countries
            Console.WriteLine("**********Get lastest news by country**********");
            var res2 = client.News.GetByCountry(new string[] { "united states" });
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // Get latest news by indicator, or indicators
            Console.WriteLine("**********Get latest news by indicator**********");
            var res3 = client.News.GetByIndicator(new string[] { "inflation rate" });
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // Get news by country and indicator, or countries and indicators
            Console.WriteLine("**********Get news by country and indicator**********");
            var res4 = client.News.GetByCountryIndicator(new string[] { "united states" }, new string[] { "inflation rate" });
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // Paginate news list by specifying start index and list size
            Console.WriteLine("**********Get start index and list size**********");
            var res5 = client.News.GetByList(4, 2);
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            Console.ReadLine();
        }


    }
}