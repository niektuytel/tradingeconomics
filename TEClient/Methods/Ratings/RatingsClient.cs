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
using TEClient.Methods.News;
using TEClient.Methods.News.Queries;
using TEClient.Methods.Ratings.Queries;

namespace TEClient.Methods.Ratings;

public class RatingsClient : ApiBase
{
    public RatingsClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// Get all ratings without filters
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<RatingsResponse>GetAll()
    {
        return Query<GetRatings>();
    }

    /// <summary>
    /// Get a list of ratings form a specific country
    /// </summary>
    /// <param name="country">Name of the country</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<RatingsResponse> GetByCountry(string country)
    {
        return Query<GetRatingsByCountry>($"/{country}");
    }

    /// <summary>
    /// Get ratings by countries
    /// </summary>
    /// <param name="countries">Name of the country</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<RatingsResponse> GetByCountries(string[] countries)
    {
        return Query<GetRatingsByCountries>($"/{string.Join(",", countries)}");
    }

    /// <summary>
    /// Get historical ratings given countries
    /// </summary>
    /// <param name="countries">List of countries</param>

    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<RatingsResponse> GetHistorical(string[] countries)
    {

        return Query<GetHistoricalRatings>($"/{string.Join(",", countries)}");
    }

}
