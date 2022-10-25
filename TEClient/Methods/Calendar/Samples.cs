using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TEClient;

namespace CSharpExamples
{
    class Calendar
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get  calendar events
            Console.WriteLine("About to get calendar events");
            var res1 = client.Calendar.GetEvents();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get calendar events between two dates
            Console.WriteLine("About to get all calendar events between dates");
            var res2 = client.Calendar.GetEventsByCountriesAndDates(new DateTime(2016, 12, 02), new DateTime(2016, 12, 03));
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // get  calendar events for a specific country
            Console.WriteLine("About to get calendar events for a specific country");
            var res3 = client.Calendar.GetEventsByCountries("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // get calendar events for a set of countries
            Console.WriteLine("About to get calendar events for a set of countries");
            var res4 = client.Calendar.GetEventsByCountries("united states", "china");
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // get calendar events by country/countries and dates
            Console.WriteLine("About to get calendar events by date and countries");
            var res5 = client.Calendar.GetEventsByCountriesAndDates(new DateTime(2016, 02, 01), new DateTime(2016, 02, 10), "united states", "china");
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            // get calendar events by indicator
            Console.WriteLine("About to get calendar events by economics indicator");
            var res6 = client.Calendar.GetEventsByIndicator("inflation rate");
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            // get calendar events by indicator and dates
            Console.WriteLine("About to get calendar events by economics indicator and dates");
            var res7 = client.Calendar.GetEventsByIndicatorAndDates(new DateTime(2016, 03, 01), new DateTime(2016, 03, 03), "inflation rate");
            Console.WriteLine(JsonConvert.SerializeObject(res7));

            // get calendar events by indicator, countries and dates
            Console.WriteLine("About to get calendar events by economics indicator, countries and dates");
            var res8 = client.Calendar.GetEventsByIndicatorCountriesAndDates(new DateTime(2016, 12, 01), new DateTime(2017, 02, 25), new string[] { "united states" }, "inflation rate");
            Console.WriteLine(JsonConvert.SerializeObject(res8));

            // get calendar events by id
            Console.WriteLine("About to get calendar events by id");
            var res9 = client.Calendar.GetEventsById(174108, 160025, 160030);
            Console.WriteLine(JsonConvert.SerializeObject(res9));

            Console.ReadLine();
        }
    }
}
