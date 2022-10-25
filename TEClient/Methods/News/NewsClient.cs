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
using TEClient.Methods.News.Queries;

namespace TEClient.Methods.News;

public class NewsClient : ApiBase
{
    public NewsClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// get latest news
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<NewsResponse> GetAll()
    {
        return Query<GetNews>();
    }

    /// <summary>
    /// Filter news by country
    /// </summary>
    /// <param name="countries">country</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<NewsResponse> GetByCountry(string[] countries)
    {

        return Query<GetNewsByCountry>($"/{string.Join(",", countries)}");

    }

    /// <summary>
    /// Filter news by indicator
    /// </summary>
    /// <param name="countries">country</param>
    /// <param name="indicators">indicatord</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<NewsResponse> GetByIndicator(string[] indicators)
    {

        return Query<GetNewsByIndicator>($"/{string.Join(",", indicators)}");

    }

    /// <summary>
    /// Filter news by country and indicator
    /// </summary>
    /// <param name="indicators">indicator</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<NewsResponse> GetByCountryIndicator(string[] countries, string[] indicators)
    {

        return Query<GetNewsCountryIndicator>($"/{string.Join(",", countries)}/{string.Join(",", indicators)}");

    }

    /// <summary>
    /// get latest news start index and limit size list
    /// </summary>
    /// <param name="list_size">list size</param>
    /// <param name="start_index">Start index</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<NewsResponse> GetByList(int list_size, int start_index)
    {
        return Query<GetNewsList>($"?limit={list_size}&start={start_index}");
    }



}
