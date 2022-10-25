using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TEClient;

namespace CSharpExamples
{
    class Streamer
    {
        static async Task Main(string[] args)
        {
            var client = new ApiClient();


            Console.WriteLine("Enter a topic (ex EURUSD:CUR,calendar): ");
            string topic = Console.ReadLine();

            Console.WriteLine("Subscribing to " + topic);
            Console.WriteLine("About to connect the socket!");

            // this method receives as paramenter the name of the topic you are subscribing for
            // for a complete reference, refer to: http://docs.tradingeconomics.com/ searching for STREAMING
            await client.Streaming.Run(topic);

            Console.WriteLine("Connection closed, press any key to exit...");
            Console.ReadLine();
        }
    }
}
