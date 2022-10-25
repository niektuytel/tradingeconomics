using Newtonsoft.Json;
using System;
using TEClient.Methods.Calendar;
using TEClient.Methods.Comtrade;
using TEClient.Methods.Earnings;
using TEClient.Methods.FederalReserve;
using TEClient.Methods.Forecast;
using TEClient.Methods.Indicator;
using TEClient.Methods.LatestUpdates;
using TEClient.Methods.Markets;
using TEClient.Methods.News;
using TEClient.Methods.Ratings;
using TEClient.Methods.Streaming;
using TEClient.Methods.WorldBank;

namespace TEClient;

public class ApiClient : ApiBase
{
    private readonly string _baseUrl;
    private readonly string _clientKey;

    public ApiClient(string baseUrl="", string clientKey="")
    { 
        _baseUrl = baseUrl;
        _clientKey = clientKey; 
    }

    public FederalReserveClient FederalReserve => new(_baseUrl, _clientKey);

    public EarningsClient Earnings => new(_baseUrl, _clientKey);

    public CalendarClient Calendar => new(_baseUrl, _clientKey);

    public ComtradeClient Comtrade => new(_baseUrl, _clientKey);

    public ForecastClient Forecast => new(_baseUrl, _clientKey);

    public IndicatorClient Indicator => new(_baseUrl, _clientKey);

    public LatestUpdatesClient LatestUpdate => new(_baseUrl, _clientKey);

    public MarketsClient Market => new(_baseUrl, _clientKey);

    public NewsClient News => new(_baseUrl, _clientKey);

    public RatingsClient Ratings => new(_baseUrl, _clientKey);

    public WorldBankClient WorldBank => new(_baseUrl, _clientKey);

    public StreamingClient Streaming => new(_baseUrl, _clientKey);

}
