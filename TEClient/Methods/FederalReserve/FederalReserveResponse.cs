using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.FederalReserve;

public class FederalReserveResponse
{
    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("Country")]
    public string Country { get; set; }

    [JsonProperty("Category")]
    public string Category { get; set; }

    [JsonProperty("Last")]
    public float Last { get; set; }

    [JsonProperty("Date")]
    public DateTime Date { get; set; }

    [JsonProperty("Previous")]
    public float Previous { get; set; }

    [JsonProperty("PreviousDate")]
    public DateTime PreviousDate { get; set; }

    [JsonProperty("Frequency")]
    public string Frequency { get; set; }

    [JsonProperty("popularity")]
    public int Popularity { get; set; }

    [JsonProperty("Start")]
    public DateTime Start { get; set; }

    [JsonProperty("Unit")]
    public string Unit { get; set; }

    [JsonProperty("Adjustment")]
    public string Adjustment { get; set; }

    [JsonProperty("URL")]
    public string URL { get; set; }

    [JsonProperty("lastUpdate")]
    public DateTime LastUpdate { get; set; }

    [JsonProperty("county")]
    public string County { get; set; } = "";

    [JsonProperty("value")]
    public float Value { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; } = "";
}
