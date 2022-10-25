using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Markets;

public class MarketsResponse
{
    public string Ticker { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public float Last { get; set; }
    public DateTime CloseDate { get; set; }
    public string Group { get; set; }
    public string URL { get; set; }
    public int Importance { get; set; }
    public float DailyChange { get; set; }
    public float DailyPercentualChange { get; set; }
    public float WeeklyChange { get; set; }
    public float WeeklyPercentualChange { get; set; }
    public float MonthlyChange { get; set; }
    public float MonthlyPercentualChange { get; set; }
    public float YearlyChange { get; set; }
    public float YearlyPercentualChange { get; set; }
    public float YTDChange { get; set; }
    public float YTDPercentualChange { get; set; }
    public float day_high { get; set; }
    public float day_low { get; set; }
    public float yesterday { get; set; }
    public float lastWeek { get; set; }
    public float lastMonth { get; set; }
    public float lastYear { get; set; }
    public float startYear { get; set; }
    public float decimals { get; set; }
    public string unit { get; set; }
    public string frequency { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public string Type { get; set; }
    public string state { get; set; }
    public float? MarketCap { get; set; }
    public string ISIN { get; set; }
    public string Frequency { get; set; }

    public string Symbol { get; set; }
    public DateTime Date { get; set; }
    public float Open { get; set; }
    public float High { get; set; }
    public float Low { get; set; }
    public float Close { get; set; }

}
