using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TEClient.Attributes;
using TEClient.Methods.Earnings.Queries;
using TEClient.Methods.FederalReserve;
using TEClient.Methods.FederalReserve.Models;

namespace TEClient.Methods.FederalReserve;

public class FederalReserveClient : ApiBase
{
    public FederalReserveClient(string baseUrl = "", string clientKey = "") : base(baseUrl, clientKey)
    { }

    public IEnumerable<FederalReserveResponse> GetStates()
    {
        return Query<GetFederalReserveState>();
    }

    public IEnumerable<FederalReserveResponse> GetStatesByCounty(string county)
    {
        return Query<GetFederalReserveCounties>(county);
    }

    public IEnumerable<FederalReserveResponse> GetBySymbol(string symbol)
    {
        return Query<GetFederalReserveBySymbol>(symbol);
    }

    public IEnumerable<FederalReserveResponse> GetByUrl(string url)
    {
        return Query<GetFederalReserveByUrl>(url);
    }

    public IEnumerable<FederalReserveResponse> GetByCountry(string country)
    {
        return Query<GetFederalReserveByCountry>(country);
    }

    public IEnumerable<FederalReserveResponse> GetByCountry(string country, int page)
    {
        return Query<GetFederalReserveByCountry>($"{country}/{page}");
    }

    public IEnumerable<FederalReserveResponse> GetByState(string state)
    {
        return Query<GetFederalReserveByState>(state);
    }

    public IEnumerable<FederalReserveResponse> GetByCounty(string county)
    {
        return Query<GetFederalReserveByCounty>(county);
    }

    public IEnumerable<FederalReserveResponse> GetHistoryBySymbol(string symbol)
    {
        return Query<GetFederalReserveHistoryBySymbol>(symbol);
    }

    public IEnumerable<FederalReserveResponse> GetHistoryBySymbols(string[] symbols)
    {
        var value = string.Join(",", symbols);
        return Query<GetFederalReserveHistoryBySymbol>(value);
    }

}
