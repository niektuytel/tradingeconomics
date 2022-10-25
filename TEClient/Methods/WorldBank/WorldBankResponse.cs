using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.WorldBank;

public class WorldBankResponse
{
    public string Category { get; set; }
    public string Series_code { get; set; }
    public string Series_name { get; set; }
    public string Sub_category { get; set; }
    public string Sub_category2 { get; set; }
    public string Title { get; set; }
    public string Long_definition { get; set; }
    public string Short_definition { get; set; }
    public string Source { get; set; }
    public string Aggregation_method { get; set; }
    public string URL { get; set; }
    public string Organization { get; set; }
    public string Unit { get; set; }
    public string Verbose_unit { get; set; }
    public DateTime Last_update { get; set; }
    public string Sub_category3 { get; set; }
    public string symbol { get; set; }
    public DateTime date { get; set; }
    public float value { get; set; }
    public float last { get; set; }
    public float previous { get; set; }
    public DateTime previousDate { get; set; }
    public string country { get; set; }
    public string category { get; set; }
    public string description { get; set; }
    public string frequency { get; set; }
    public string unit { get; set; }
    public string title { get; set; }
    public DateTime lastUpdate { get; set; }

}
