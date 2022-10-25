using RestSharp;

namespace TEClient.Attributes;

internal class ApiEndpointAttribute : Attribute
{
    public string Value { get; init; }

    public ApiEndpointAttribute(string endpoint)
    {
        endpoint = endpoint.Replace("//", "/");
        endpoint = endpoint.Replace("\\", "/");
        endpoint = endpoint.Replace("\\\\", "/");

        if (endpoint.First() != '/')
        {
            endpoint = $"/{endpoint}";
        }

        if (endpoint.Last() == '/')
        {
            endpoint = endpoint.Remove(endpoint.Length - 1);
        }

        Value = endpoint;
    }

    public static string GetEndpoint<T>()
    {
        var endpoint = (ApiEndpointAttribute?)GetCustomAttribute(typeof(T), typeof(ApiEndpointAttribute));
        if(endpoint == null || string.IsNullOrEmpty(endpoint.Value))
        {
            return "";
        }

        return endpoint.Value;
    }

}