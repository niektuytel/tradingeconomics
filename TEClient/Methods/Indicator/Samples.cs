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
    class Indicator
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get a list of indicators
            Console.WriteLine("About to get all indicators");
            var res1 = client.Indicator.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get a list of indicators from a country
            Console.WriteLine("About to get a list of indicators of a country");
            var res2 = client.Indicator.GetByCountry("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // get an indicators from all countries
            Console.WriteLine("About to get a indicator for all country");
            var res3 = client.Indicator.GetAllCountries("gdp");
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // get historical indicators given countries and indicators
            Console.WriteLine("About to get a list of indicator for multiple countries");
            var res4 = client.Indicator.GetHistoricalByCountries(new string[] { "united states" }, new string[] { "gdp" });
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // get historical indicators given countries and indicators between start and end dates
            Console.WriteLine("About to get a historical list of indicator for multiple countries between start and end dates");
            var res5 = client.Indicator.GetHistoricalByCountries(new string[] { "united states" }, new string[] { "gdp" }, new DateTime(2015, 01, 01), new DateTime(2015, 12, 31));
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            // get historical data given a ticker
            Console.WriteLine("About to get historical data given a ticker");
            var res6 = client.Indicator.GetHistorycalByTicker("USURTOT", new DateTime(2015, 03, 01));
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            Console.ReadLine();
        }

    }
}
