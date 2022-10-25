using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Calendar;

public class CalendarResponse
{
    public string CalendarId { get; set; }
    public DateTime Date { get; set; }
    public string Country { get; set; }
    public string Category { get; set; }
    public string Event { get; set; }
    public string Reference { get; set; }
    public object ReferenceDate { get; set; }
    public string Source { get; set; }
    public string SourceURL { get; set; }
    public string Actual { get; set; }
    public string Previous { get; set; }
    public string Forecast { get; set; }
    public string TEForecast { get; set; }
    public string URL { get; set; }
    public string DateSpan { get; set; }
    public int Importance { get; set; }
    public DateTime LastUpdate { get; set; }
    public string Revised { get; set; }
    public string Currency { get; set; }
    public string Unit { get; set; }
    public string Ticker { get; set; }
    public string Symbol { get; set; }

}
