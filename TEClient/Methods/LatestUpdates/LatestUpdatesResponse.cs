using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.LatestUpdates;

public class LatestUpdatesResponse
{
    public string Country { get; set; }
    public string Category { get; set; }
    public string HistoricalDataSymbol { get; set; }
    public DateTime LastUpdate { get; set; }
}
