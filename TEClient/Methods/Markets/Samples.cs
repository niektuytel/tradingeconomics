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
    class Markets
    {
        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get markets commodities
            Console.WriteLine("***********Get commodities***********");
            var res1 = client.Market.GetCommodities();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get markets currency
            Console.WriteLine("***********Get currency***********");
            var res2 = client.Market.GetCurrency();
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            // get currency crosses
            Console.WriteLine("***********Get currency crosses***********");
            var res3 = client.Market.GetCurrencyCrosses();
            Console.WriteLine(JsonConvert.SerializeObject(res3));

            // get markets indexes
            Console.WriteLine("***********Get markets indexes***********");
            var res4 = client.Market.GetBonds();
            Console.WriteLine(JsonConvert.SerializeObject(res4));

            // get markets bond
            Console.WriteLine("***********Get markets indexes***********");
            var res5 = client.Market.GetIndex();
            Console.WriteLine(JsonConvert.SerializeObject(res5));

            // get markets for multiple symbols 
            Console.WriteLine("***********Get markets for multiple symbols***********");
            var res6 = client.Market.GetBySymbols(new string[] { "aapl:us", "indu:ind" });
            Console.WriteLine(JsonConvert.SerializeObject(res6));

            // get markets for a specific symbol
            Console.WriteLine("***********Get markets for a specific symbol***********");
            var res7 = client.Market.GetBySymbol("aapl:us");
            Console.WriteLine(JsonConvert.SerializeObject(res7));

            // get markets peers 
            Console.WriteLine("***********Get markets peers***********");
            var res8 = client.Market.GetPeersBySymbol("aapl:us");
            Console.WriteLine(JsonConvert.SerializeObject(res8));

            // get stock market index components
            Console.WriteLine("***********Get stock market index components***********");
            var res9 = client.Market.GetComponentsBySymbol("psi20:ind");
            Console.WriteLine(JsonConvert.SerializeObject(res9));

            //get stock market by country and page number
            Console.WriteLine("***********Get stock market by country and page number********");
            var res10 = client.Market.GetByCountryPage("united states");
            Console.WriteLine(JsonConvert.SerializeObject(res10));

            // get historical markets data by market
            Console.WriteLine("**********Get historical markets data by symbol**********");
            var res11 = client.Market.GetHistoricalBySymbol("aapl:us");
            Console.WriteLine(JsonConvert.SerializeObject(res11));

            // get historical markets data by multiple markets
            Console.WriteLine("**********Get historical markets data by multiple symbols**********");
            var res12 = client.Market.GetHistoricalBySymbols(new string[] { "aapl:us", "indu:ind" });
            Console.WriteLine(JsonConvert.SerializeObject(res12));

            // get historical markets data by date
            Console.WriteLine("**********Get historical markets data by date**********");
            var res13 = client.Market.GetHistoricalSymbolDate("indu:ind", new DateTime(2015, 01, 01));
            Console.WriteLine(JsonConvert.SerializeObject(res13));

            // get historical markets data within a date interval
            Console.WriteLine("**********Get historical markets data between dates**********");
            var res14 = client.Market.GetByHistoricalSymbolBetweenDates("aapl:us", new DateTime(2015, 03, 01), new DateTime(2015, 12, 31));
            Console.WriteLine(JsonConvert.SerializeObject(res14));

            // get Intraday prices for a single market
            Console.WriteLine("**********Get Intraday prices for a single market**********");
            var res15 = client.Market.GetByIntradaySymbol("aapl:us");
            Console.WriteLine(JsonConvert.SerializeObject(res15));

            // Filter intraday prices by date and hour
            Console.WriteLine("**********Get intraday prices by date and hour**********");
            var res16 = client.Market.GetByIntradayDateHour("indu:ind", new DateTime(2015, 01, 01, 15, 00, 0));
            Console.WriteLine(JsonConvert.SerializeObject(res16));

            // Filter intraday prices by date
            Console.WriteLine("**********Get intraday data by symbol between dates**********");
            var res17 = client.Market.GetByIntradaySymbolDates("aapl:us", new DateTime(2015, 03, 01), new DateTime(2015, 12, 31));
            Console.WriteLine(JsonConvert.SerializeObject(res17));

            Console.ReadLine();
        }
    }
}