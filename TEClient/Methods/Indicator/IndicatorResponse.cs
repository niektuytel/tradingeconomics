using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Indicator;

public class IndicatorResponse
{
    public string Country { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public float LatestValue { get; set; }
    public DateTime LatestValueDate { get; set; }
    public float q1 { get; set; }
    public float q2 { get; set; }
    public float q3 { get; set; }
    public float q4 { get; set; }
    public float YearEnd { get; set; }
    public float YearEnd2 { get; set; }
    public float YearEnd3 { get; set; }
    public DateTime q1_date { get; set; }
    public DateTime q2_date { get; set; }
    public DateTime q3_date { get; set; }
    public DateTime q4_date { get; set; }
    public string Frequency { get; set; }
    public string HistoricalDataSymbol { get; set; }

}
