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
using TEClient.Methods.Forecast.Queries;
using TEClient.Methods.Indicator.Queries;
using TEClient.Methods.Markets.Queries;

namespace TEClient.Methods.Markets;

public class MarketsClient : ApiBase
{
    public MarketsClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// Get currency
    /// </summary>
    /// <param name="commodities">commodities</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetCommodities()
    {
        return Query<GetMarketCommodities>();
    }

    /// <summary>
    /// Get currency 
    /// </summary>
    /// <param name="currency">currency</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetCurrency()
    {

        return Query<GetMarketCurrency>();
    }

    /// <summary>
    /// Get currency crosses
    /// </summary>
    /// <param name="currency">currency</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetCurrencyCrosses()
    {

        return Query<GetMarketCurrencyCrosses>("?cross=eur");
    }

    /// <summary>
    /// Get market index
    /// </summary>
    /// <param name="index">index</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetIndex()
    {

        return Query<GetMarketIndex>();
    }

    /// <summary>
    /// Get Bonds
    /// </summary>
    /// <param name="bonds">bonds</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetBonds()
    {

        return Query<GetMarketBonds>();
    }


    /// <summary>
    /// Get markets by symbols
    /// </summary>
    /// <param name="symbols">List of symbols</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetBySymbols(string[] symbols)
    {

        return Query<GetMarketSymbols>($"/{string.Join(",", symbols)}");
    }
    /// <summary>
    /// Get markets by a specific symbol 
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetBySymbol(string symbol)
    {
        return Query<GetMarketSymbols>($"/{symbol}");
    }

    /// <summary>
    /// Get markets peers
    /// </summary>
    /// <param name="peers">peers</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetPeersBySymbol(string symbol)
    {

        return Query<GetMarketPeers>($"/{symbol}");
    }

    /// <summary>
    /// Get components
    /// </summary>
    /// <param name="components">peers</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetComponentsBySymbol(string symbol)
    {

        return Query<GetMarketComponents>($"/{symbol}");
    }

    /// <summary>        
    /// /// Get markets by country and page number
    /// </summary>
    /// <param name="country">List of countries</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetByCountryPage(string country)
    {

        return Query<GetMarketByCountryPage>($"/{country}", "?page=2");
    }


    /// <summary>
    /// Get markets historical data by symbol
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetHistoricalBySymbol(string symbol)
    {
        return Query<GetMarketHistoricalBySymbol>($"/{symbol}");
    }

    /// <summary>
    /// Get a list of symbols
    /// </summary>
    /// <param name="symbols">Name of the symbols</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetHistoricalBySymbols(string[] symbols)
    {
        return Query<GetMarketHistoricalBySymbol>($"/{string.Join(",", symbols)}");
    }

    /// <summary>
    /// Get historical data by symbol and start date
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <param name="startDate">Start date if needed</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetHistoricalSymbolDate(string symbol, DateTime? startDate)
    {

        return Query<GetMarketHistoricalBySymbol>($"/{symbol}?{startDate:yyyy-MM-dd}");

    }

    /// <summary>
    /// Get historical markets data by symbol, start and end date
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <param name="startDate">Start date</param>
    /// <param name="endDate">End date</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetByHistoricalSymbolBetweenDates(string symbol, DateTime? startDate = null, DateTime? endDate = null)
    {

        return Query<GetMarketHistoricalBySymbol>($"/{symbol}?{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}");
    }

    /// <summary>
    /// get Intraday prices for a single market
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetByIntradaySymbol(string symbol)
    {
        return Query<GetMarketIntraday>($"/{symbol}");
    }

    /// <summary>
    /// Filter intraday prices by date and hour
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <param name="startDate">Start date if needed</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetByIntradayDateHour(string symbol, DateTime? startDate)
    {

        return Query<GetMarketIntraday>($"/{symbol}?{startDate:yyyy-MM-dd %h}");

    }

    /// <summary>
    /// Get historical markets data by symbol, start and end date
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <param name="startDate">Start date</param>
    /// <param name="endDate">End date</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<MarketsResponse> GetByIntradaySymbolDates(string symbol, DateTime? startDate = null, DateTime? endDate = null)
    {
        return Query<GetMarketIntraday>($"/{symbol}?{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}");
    }



}
