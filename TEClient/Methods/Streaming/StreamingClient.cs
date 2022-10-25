using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Streaming
{
    public class StreamingClient
    {
        private readonly string _baseUrl = "ws://stream.tradingeconomics.com";
        private readonly string _clientKey = "guest:guest";

        public StreamingClient(string baseUrl = "", string clientKey = "")
        {
            if (!string.IsNullOrEmpty(baseUrl)) _baseUrl = baseUrl;
            if (!string.IsNullOrEmpty(clientKey)) _clientKey = clientKey;
        }

        /// <summary>
        /// Connects with the TE Streaming throught a WebSocket keep receiving the information from TE while
        /// the connection is open.
        /// This method should be running in a separate thread since it would block the program flow while running.
        /// </summary>
        /// <param name="subscribeTo">Name of the topic to subscribe</param>
        public async Task Run(string subscribeTo)
        {
            try
            {
                using (var cws = new ClientWebSocket())
                {
                    await cws.ConnectAsync(new Uri($"{_baseUrl}/?client={_clientKey}"), CancellationToken.None);

                    if (cws.State == WebSocketState.Open)
                    {
                        var buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(@"{""topic"": ""subscribe"", ""to"": """ + subscribeTo + @""" }"));
                        await cws.SendAsync(buffer, WebSocketMessageType.Binary, true, CancellationToken.None);
                    }

                    await Task.Delay(1024);

                    while (cws.State == WebSocketState.Open)
                    {
                        var buffer = new ArraySegment<byte>(new byte[1024]);
                        var result = await cws.ReceiveAsync(buffer, CancellationToken.None);
                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            await cws.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                        }

                        Console.WriteLine($"Receiving: {Encoding.UTF8.GetString(buffer.Array, 0, result.Count).Trim()}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error with message: {e.Message}");
            }
        }

    }
}
