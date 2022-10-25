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
    class Comtrade
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get comtrade categories
            Console.WriteLine("**********Get comtrade categories**********");
            var res1 = client.Comtrade.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get comtrade countries 
            Console.WriteLine("**********Get comtrade countries **********");
            var res2 = client.Comtrade.GetCountries();
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // Filtering by the country and page number
            Console.WriteLine("**********Get comtrade by country and page number**********");
            var res3 = client.Comtrade.GetCountryPage("portugal", 4);
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // get comtrade between two countries and page number
            Console.WriteLine("**********Get comtrade countries and page number**********");
            var res4 = client.Comtrade.GetBetweenCountries("portugal", "spain", 2);
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // Get comtrade historical data by symbol
            Console.WriteLine("**********Get comtrade historical data by symbol**********");
            var res5 = client.Comtrade.GetHistorical("PRTESP24031");
            Console.WriteLine(JsonConvert.SerializeObject(res5));


            Console.ReadLine();
        }
    }
}