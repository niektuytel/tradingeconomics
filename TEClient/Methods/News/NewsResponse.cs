using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.News;

public class NewsResponse
{
    public string id { get; set; }
    public string title { get; set; }
    public DateTime date { get; set; }
    public string description { get; set; }
    public string country { get; set; }
    public string category { get; set; }
    public string symbol { get; set; }
    public string url { get; set; }
}
