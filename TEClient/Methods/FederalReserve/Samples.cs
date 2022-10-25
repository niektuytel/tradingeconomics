

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TEClient;
using TEClient.Methods.FederalReserve;

namespace CSharpExamples
{
    class Markets
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get fred categories
            Console.WriteLine("**********Get federal reserve states**********");
            var res1 = client.FederalReserve.GetStates();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get fred per states
            Console.WriteLine("**********Get federal reserve data per state**********");
            var res2 = client.FederalReserve.GetByCounty("arkansas");
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // Filtering by symbol
            Console.WriteLine("**********Get federal reserve data by symbol**********");
            var res3 = client.FederalReserve.GetBySymbol("AGEXMAK2A647NCEN");
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // Filtering by url
            Console.WriteLine("**********Get federal reserve data by url**********");
            var res4 = client.FederalReserve.GetByUrl("/united-states/income-inequality-in-aleutians-east-borough-ak-fed-data.html");
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // Get fred data by county
            Console.WriteLine("**********Get federal reserve by county**********");
            var res7 = client.FederalReserve.GetByCounty("arkansas");
            Console.WriteLine(JsonConvert.SerializeObject(res7));

            // Get fred data by state
            Console.WriteLine("**********Get federal reserve by state**********");
            var res6 = client.FederalReserve.GetByState("tennessee");
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            // Get fred data by country
            Console.WriteLine("**********Get federal reserve country**********");
            var res5 = client.FederalReserve.GetByCountry("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            // Get fred data by country and page
            Console.WriteLine("**********Get federal reserve by country and page**********");
            var res8 = client.FederalReserve.GetByCountry("united states", 2);
            Console.WriteLine(JsonConvert.SerializeObject(res8));

            // Get fred historical by symbol 
            Console.WriteLine("**********Get federal reserve historical by symbol**********");
            var res9 = client.FederalReserve.GetHistoryBySymbol("RACEDISPARITY005007");
            Console.WriteLine(JsonConvert.SerializeObject(res9));

            // Get fred historical by symbols 
            Console.WriteLine("**********Get federal reserve historical by symbols**********");
            var res10 = client.FederalReserve.GetHistoryBySymbols(new string[] { "RACEDISPARITY005007", "2020RATIO002013"});
            Console.WriteLine(JsonConvert.SerializeObject(res10));
        }
    }
}







