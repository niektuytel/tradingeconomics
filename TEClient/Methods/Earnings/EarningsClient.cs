using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEClient.Methods.Earnings;
using TEClient.Methods.Earnings.Queries;
using TEClient.Methods.FederalReserve;
using TEClient.Methods.FederalReserve.Models;

namespace TEClient.Methods.Earnings;

public class EarningsClient : ApiBase
{
    public EarningsClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// get earnings calendar
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<EarningsResponse> GetAll()
    {
        return Query<GetEarnings>();
    }

    /// <summary>
    /// Filter earnings by date
    /// </summary>
    /// <param name="startDate">Start date if needed</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<EarningsResponse> GetAllByDate(DateTime startDate)
    {
        return Query<GetEarnings>($"?d1={startDate:yyyy-MM-dd}");
    }

    /// <summary>
    /// Get earnings by market, and start date
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <param name="startDate">Start date</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<EarningsResponse> GetAllByMarketDate(string symbol, DateTime? startDate = null)
    {
        return Query<GetEarningsBySymbol>($"/{symbol}", $"?d1={startDate:yyyy-MM-dd}");
    }

    /// <summary>
    /// Get earnings by market, start and end date
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <param name="startDate">Start date</param>
    /// <param name="endDate">End date</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<EarningsResponse> GetAllByMarketDateRange(string symbol, DateTime? startDate = null, DateTime? endDate = null)
    {
        return Query<GetEarningsBySymbol>($"/{symbol}", $"?d1={startDate:yyyy-MM-dd}&d2={endDate:yyyy-MM-dd}");
    }

    /// <summary>
    /// Get earnings by country
    /// </summary>
    /// <param name="country">symbol</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<EarningsResponse> GetByCountry(string country)
    {
        return Query<GetEarningsByCountry>($"/{country}");
    }

    /// <summary>
    /// Get earnings by type
    /// </summary>
    /// <param name="type">symbol</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<EarningsResponse> GetByType(string type)
    {

        return Query<GetEarnings>($"?type={type}");
    }
}
