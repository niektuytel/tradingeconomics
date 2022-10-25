using TEClient.Interfaces;

namespace TEClient.Methods.FederalReserve;

internal interface IGetWithQuery
{ }

internal class QueryString : IGetWithQuery
{
    public QueryString(string query)
    {
        Value = query;
    }

    public string Value { get; init; }

    public static implicit operator QueryString(string query)
    {
        return new QueryString(query);
    }

    //var query = $"?";
    //foreach (var item in queries)
    //{
    //    if(query == "?")
    //    {
    //        query += $"{item.Key}={item.Value}";
    //    }
    //    else
    //    {
    //        query += $"&{item.Key}={item.Value}";
    //    }
    //}
}