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
using TEClient.Methods.WorldBank.Queries;

namespace TEClient.Methods.WorldBank;

public class WorldBankClient : ApiBase
{
    public WorldBankClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// get main categories
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetAll()
    {
        return Query<GetWorldBank>();
    }

    /// <summary>
    /// Filter by category
    /// </summary>
    /// <param name="category">category</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetCategory(string category)
    {

        return Query<GetWorldBankCategory>($"/{category}");

    }


    /// <summary>
    /// Get WB by category and page number
    /// </summary>
    /// <param name="category">category</param>
    /// <param name="page_number">pagination</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetCategoryPage(string category, int page_number)
    {

        return Query<GetWorldBankCategoryPage>($"/{category}/{page_number}");
    }


    /// <summary>
    /// Get WB historical data for specific indicator
    /// </summary>
    /// <param name="series_code">series code</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetHistorical(string[] series_code)
    {

        return Query<GetWorldBankHistorical>($"?s={string.Join(",", series_code)}");
    }

    /// <summary>
    /// get main categories
    /// </summary>
    /// <param name="series_code">series code</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetSeries(string[] series_code)
    {
        return Query<GetWorldBankSeries>($"?s={string.Join(",", series_code)}");
    }

    /// <summary>
    /// Filter by url
    /// </summary>
    /// <param name="url1">url</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetUrl(string url1)
    {

        return Query<GetWorldBankUrl>($"?url={url1}");

    }


    /// <summary>
    /// Get WB by country and page number
    /// </summary>
    /// <param name="country">country</param>
    /// <param name="page_number">pagination</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<WorldBankResponse> GetCountryPage(string country, int page_number)
    {

        return Query<GetWorldBankCountryPage>($"/{country}/{page_number}");
    }


}
