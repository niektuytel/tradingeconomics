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
    class Ratings
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get a list of credit ratings
            Console.WriteLine("***********Get all ratings***********");
            var res1 = client.Ratings.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get a list of ratings from a country
            Console.WriteLine("***********Get a list of ratings of a country***********");
            var res2 = client.Ratings.GetByCountry("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // get ratings given countries 
            Console.WriteLine("***********Get a list of ratings for multiple countries***********");
            var res3 = client.Ratings.GetByCountries(new string[] { "united states", "portugal" });
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // get historical ratings for multiple countries 
            Console.WriteLine("***********Get historical data of ratings for multiple countries***********");
            var res4 = client.Ratings.GetHistorical(new string[] { "united states", "portugal" });
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            Console.ReadLine();
        }

    }
}