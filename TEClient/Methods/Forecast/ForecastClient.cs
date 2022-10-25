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

namespace TEClient.Methods.Forecast;

public class ForecastClient : ApiBase
{
    public ForecastClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// Get forecasts for a sprecific country
    /// </summary>
    /// <param name="country">Name of the country</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ForecastResponse> GetByCountry(string country)
    {
        return Query<GetForecastByCountry>($"/{country}");
    }

    /// <summary>
    /// Get forecasts by countries 
    /// </summary>
    /// <param name="countries">List of countries</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ForecastResponse> GetByCountries(string[] countries)
    {
        return Query<GetForecastByCountries>($"/{string.Join(",", countries)}");
    }

    /// <summary>
    /// Get forecasts by indicators 
    /// </summary>
    /// <param name="indicators">List of indicators</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ForecastResponse> GetMultiIndicator(string[] indicators)
    {
        return Query<GetForecastsMultiIndicator>($"/{string.Join(",", indicators)}");
    }

    /// <summary>
    /// Get forecasts for a a specific indicator 
    /// </summary>
    /// <param name="indicator">Name of the indicator</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ForecastResponse> GetByIndicator(string indicator)
    {
        return Query<GetForecastsByIndicator>($"/{indicator}");
    }

    /// <summary>
    /// Get forecasts for a single country and indicator
    /// </summary>
    /// <param name="country">List of countries</param>
    /// <param name="indicator">List of indicators</param>

    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ForecastResponse> GetByCountryIndicator(string country, string indicator)
    {

        return Query<GetForecastsByCountryIndicator>($"/{country}/indicator/{indicator}");
    }


    /// <summary>
    /// Get forecasts by countries and indicators
    /// </summary>
    /// <param name="countries">List of countries</param>
    /// <param name="indicators">List of indicators</param>

    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<ForecastResponse> GetByCountriesIndicators(string[] countries, string[] indicators)
    {

        return Query<GetForecastsByCountriesIndicators>($"/{string.Join(",", countries)}/indicator/{string.Join(",", indicators)}");
    }

}
