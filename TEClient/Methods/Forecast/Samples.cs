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
    class Forecast
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get forecasts for a specific country
            Console.WriteLine("***********Get forecasts for a specific country***********");
            var res1 = client.Forecast.GetByCountry("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get forecasts for multiple countries 
            Console.WriteLine("***********Get forecasts for multiple countries***********");
            var res2 = client.Forecast.GetByCountries(new string[] { "united states" });
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // get forecasts for a specific indicator
            Console.WriteLine("***********Get forecasts for a specific indicator***********");
            var res3 = client.Forecast.GetByIndicator("gdp");
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // get forecasts for multiple indicators
            Console.WriteLine("***********Get forecasts for multiple indicators***********");
            var res4 = client.Forecast.GetMultiIndicator(new string[] { "gdp", "population" });
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // get forecasts by country and indicator
            Console.WriteLine("***********Get forecasts for country and indicator***********");
            var res5 = client.Forecast.GetByCountryIndicator("united states", "gdp");
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            //get forecasts by countries and indicators
            Console.WriteLine("***********Get forecasts for countries and indicators********");
            var res6 = client.Forecast.GetByCountriesIndicators(new string[] { "united states", "china" }, new string[] { "gdp", "population" });
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            Console.ReadLine();
        }

    }
}