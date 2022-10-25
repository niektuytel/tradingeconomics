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

namespace TEClient.Methods.Indicator;

public class IndicatorClient : ApiBase
{
    public IndicatorClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// Get all indicators without filters
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<IndicatorResponse> GetAll()
    {
        return Query<GetIndicators>();
    }

    /// <summary>
    /// Get a list of indicator form a specific country
    /// </summary>
    /// <param name="country">Name of the country</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<IndicatorResponse> GetByCountry(string country)
    {
        return Query<GetIndicatorsByCountry>($"/{country}");
    }

    /// <summary>
    /// Get a specific indicator for all countries
    /// </summary>
    /// <param name="indicator">Name of the indicator</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<IndicatorResponse> GetAllCountries(string indicator)
    {
        return Query<GetIndicatorsAllCountries>($"/{indicator}");
    }

    /// <summary>
    /// Get historical indicators given countries, indicators, start and end date
    /// </summary>
    /// <param name="countries">List of countries</param>
    /// <param name="indicators">List of indicators</param>
    /// <param name="startDate">Start date</param>
    /// <param name="endDate">End date</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<IndicatorResponse> GetHistoricalByCountries(string[] countries, string[] indicators, DateTime? startDate = null, DateTime? endDate = null)
    {
        if (startDate != null && endDate != null)
            return Query<GetHistoricalIndicatorsByCountries>($"/{string.Join(",", countries)}/indicator/{string.Join(",", indicators)}/{startDate.Value.ToString("yyyy-MM-dd")}/{endDate.Value.ToString("yyyy-MM-dd")}");

        return Query<GetHistoricalIndicatorsByCountries>($"/{string.Join(",", countries)}/indicator/{string.Join(",", indicators)}");
    }

    /// <summary>
    /// Get historical indicator data using the ticker
    /// </summary>
    /// <param name="ticker">Ticker</param>
    /// <param name="startDate">Start date if needed</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<IndicatorResponse> GetHistorycalByTicker(string ticker, DateTime? startDate)
    {
        if (startDate != null)
            return Query<GetHistorycalByTicker>($"/{ticker}/{startDate.Value.ToString("yyyy-MM-dd")}");

        return Query<GetHistorycalByTicker>($"/{ticker}");
    }
}
