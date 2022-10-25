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
    class LatestUpdates
    {
        /// <summary>
        /// Store the client key to be used through the program
        /// </summary>
        static string _clientKey = "guest:guest";

        static void Main(string[] args)
        {
            var client = new ApiClient();

            // get a list of the lastest updates
            Console.WriteLine("***********Get the latest updates***********");
            var res1 = client.LatestUpdate.GetLatestUpdates();
            Console.WriteLine(JsonConvert.SerializeObject(res1));

            // get latest updates since a specific date
            Console.WriteLine("***********About to get latest updates by a specific date***********");
            var res2 = client.LatestUpdate.GetLatestUpdatesByDate(new DateTime(2015, 03, 01));
            Console.WriteLine(JsonConvert.SerializeObject(res2));

            Console.ReadLine();
        }


    }
}
