using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Comtrade;

public class ComtradeResponse
{
    public string id { get; set; }
    public string name { get; set; }
    public string parentId { get; set; }
    public string pretty_name { get; set; }
    public string region { get; set; }
    public string subregion { get; set; }
    public string iso { get; set; }
    public string year { get; set; }
    public string symbol { get; set; }
    public string country1 { get; set; }
    public string country2 { get; set; }
    public float value { get; set; }
    public object date { get; set; }
    public string type { get; set; }
    public string category { get; set; }
    public string url { get; set; }
    public string title { get; set; }
    public DateTime lastupdate { get; set; }

}
