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
using TEClient.Methods.LatestUpdates.Queries;

namespace TEClient.Methods.LatestUpdates;

public class LatestUpdatesClient : ApiBase
{
    public LatestUpdatesClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// Get latest updates with no filters
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<LatestUpdatesResponse> GetLatestUpdates()
    {
        return Query<GetLatestUpdates>();
    }

    /// <summary>
    /// Get latest updates by date
    /// </summary>
    /// <param name="startDate">Start date if needed</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<LatestUpdatesResponse> GetLatestUpdatesByDate(DateTime startDate)
    {
        return Query<GetLatestUpdates>($"/{startDate.ToString("yyyy-MM-dd")}");
    }
}
