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
    class WBIndCoun
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get world bank categories
            Console.WriteLine("**********Get world bank categories**********");
            var res1 = client.WorldBank.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // Filtering by category
            Console.WriteLine("**********Get WB by category**********");
            var res2 = client.WorldBank.GetCategory("Education");
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // Filtering by the category and page number
            Console.WriteLine("**********Get WB by category and page number**********");
            var res3 = client.WorldBank.GetCategoryPage("Education", 4);
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // Historical data for a specific indicator
            Console.WriteLine("**********Get historical data for a specific indicator**********");
            var res4 = client.WorldBank.GetHistorical(new string[] { "usa.fr.inr.rinr" });
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // get world bank information by indicators series code
            Console.WriteLine("**********Get world bank by indicators series code**********");
            var res5 = client.WorldBank.GetSeries(new string[] { "fr.inr.rinr" });
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            // Filtering by url 
            Console.WriteLine("**********Get WB by url**********");
            var res6 = client.WorldBank.GetUrl("united-states/real-interest-rate-percent-wb-data.html");
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            // Filtering by the country and page number
            Console.WriteLine("**********Get WB by country and page number**********");
            var res7 = client.WorldBank.GetCountryPage("united states", 4);
            Console.WriteLine(JsonConvert.SerializeObject(res7));


            Console.ReadLine();
        }
    }
}