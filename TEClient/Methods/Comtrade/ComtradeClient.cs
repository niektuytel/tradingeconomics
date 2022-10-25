using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEClient.Methods.Comtrade.Queries;
using TEClient.Methods.Earnings.Queries;
using TEClient.Methods.FederalReserve;
using TEClient.Methods.FederalReserve.Models;

namespace TEClient.Methods.Comtrade;

public class ComtradeClient : ApiBase
{
    public ComtradeClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// get categories
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ComtradeResponse> GetAll()
    {
        return Query<GetComtradeCategories>();
    }

    /// <summary>
    /// get countries
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ComtradeResponse> GetCountries()
    {
        return Query<GetComtradeCountries>();
    }

    /// <summary>
    /// Get comtrade by country and page number
    /// </summary>
    /// <param name="country">country</param>
    /// <param name="page_number">pagination</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ComtradeResponse> GetCountryPage(string country, int page_number)
    {

        return Query<GetComtradeCountryPage>($"/{country}/{page_number}");
    }

    /// <summary>
    /// Get comtrade between 2 countries and page number
    /// </summary>
    /// <param name="country1">country</param>
    /// <param name="country2">country</param>
    /// <param name="page_number">pagination</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ComtradeResponse> GetBetweenCountries(string country1, string country2, int page_number)
    {

        return Query<GetComtradeCountryRange>($"/{country1}/{country2}/{page_number}");
    }

    /// <summary>
    /// Get historical by symbol
    /// </summary>
    /// <param name="symbol">country</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ComtradeResponse> GetHistorical(string symbol)
    {

        return Query<GetComtradeHistoricalSymbol>($"/{symbol}");
    }
}
