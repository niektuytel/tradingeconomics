using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.IO;
using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient;

public class ApiBase
{
    private readonly string _baseUrl = "https://api.tradingeconomics.com";
    private readonly string _clientKey = "guest:guest";

    protected ApiBase(string baseUrl="", string clientKey="")
    {
        if(!string.IsNullOrEmpty(baseUrl)) _baseUrl = baseUrl;
        if(!string.IsNullOrEmpty(clientKey)) _clientKey = clientKey;
    }

    /// <summary>
    /// Method to get Model based responses by query
    /// </summary>
    /// <typeparam name="T">Model used for requesting and responding</typeparam>
    /// <param name="query">Value as string in url query format</param>
    internal IEnumerable<T> Query<T>(QueryString query) where T : class, IGetWithQuery 
        => GetRequest<T>(query.Value);

    /// <summary>
    /// Method to get Model based responses by path
    /// </summary>
    /// <typeparam name="T">Model used for requesting and responding</typeparam>
    /// <param name="path">Value as string in url pathed format</param>
    internal IEnumerable<T> Query<T>(PathString path) where T : class, IGetWithPath 
        => GetRequest<T>(path.Value);

    /// <summary>
    /// Method to get Model based responses by path and query
    /// </summary>
    /// <typeparam name="T">Model used for requesting and responding</typeparam>
    /// <param name="path">Value as string in url pathed format</param>
    /// <param name="query">Value as string in url query format</param>
    internal IEnumerable<T> Query<T>(PathString path, QueryString query) where T : class, IGetWithPathAndQuery
        => GetRequest<T>($"{path.Value}{query.Value}");

    /// <summary>
    /// Method to get Model based responses
    /// </summary>
    /// <typeparam name="T">Model used for requesting and responding</typeparam>
    internal IEnumerable<T> Query<T>() where T : class, IGet 
        => GetRequest<T>();

    /// <summary>
    /// Url + Custom endpoint
    /// </summary>
    /// <typeparam name="T">Url endpoint from object attibute</typeparam>
    /// <param name="value">Custom addition to url</param>
    private string GetUrl<T>(string value)
    {
        var endpoint = ApiEndpointAttribute.GetEndpoint<T>();
        return $"{_baseUrl}{endpoint}{value}";
    }

    private TResponse[] GetRequest<TResponse>(string value="")
    {
        var url = GetUrl<TResponse>(value);
        var client = new RestClient(url);
        var request = new RestRequest();
        request.AddHeader("Accept", "application/xml");
        request.AddHeader("Authorization", $"Client {_clientKey}");

        var response = client.Execute(request);
        if (!response.IsSuccessStatusCode)
        {
            //var data1 = JsonConvert.DeserializeObject<TResponse[]>("[]");
            //return data1;
            throw new InvalidOperationException($"Invalid response on: {url}");
        }

        var data = JsonConvert.DeserializeObject<TResponse[]>(response.Content);
        return data;
    }

}