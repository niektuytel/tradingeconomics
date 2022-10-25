using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Earnings;

public class EarningsResponse
{
    public DateTime Date { get; set; }
    public string Symbol { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Actual { get; set; }
    public string Forecast { get; set; }
    public object FiscalTag { get; set; }
    public object FiscalReference { get; set; }
    public string CalendarReference { get; set; }
    public string Country { get; set; }
    public string Currency { get; set; }
    public int Importance { get; set; }
    public int Session { get; set; }
    public DateTime LastUpdate { get; set; }

}
