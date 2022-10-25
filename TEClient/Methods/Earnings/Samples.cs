using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TEClient;

namespace TEClient.Methods.Earnings
{
    class Earnings
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get default earnings calendar
            Console.WriteLine("**********Get earnings calendar**********");
            var res1 = client.Earnings.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // Filter earnings calendar by date
            Console.WriteLine("**********Get earnings calendar by date**********");
            var res2 = client.Earnings.GetAllByDate(new DateTime(2015, 01, 01));
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // Get earnings calendar by market and date
            Console.WriteLine("**********Get earnings calendar by market and date**********");
            var res3 = client.Earnings.GetAllByMarketDate("aapl:us", new DateTime(2015, 03, 01));
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // Get earnings calendar by market and date range
            Console.WriteLine("**********Get earnings calendar by market and date range**********");
            var res4 = client.Earnings.GetAllByMarketDateRange("aapl:us", new DateTime(2015, 03, 01), new DateTime(2015, 12, 31));
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // get default earnings calendar by country
            Console.WriteLine("**********Get earnings calendar by country**********");
            var res5 = client.Earnings.GetByCountry("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            // Filter earnings by type
            // Type can be:earnings, ipo, dividends
            Console.WriteLine("**********Get earnings by type**********");
            var res6 = client.Earnings.GetByType("earnings");
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            Console.ReadLine();
        }


    }
}