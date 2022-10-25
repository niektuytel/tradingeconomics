using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Forecast.Queries;

[ApiEndpoint("/forecast/country")]
internal class GetForecastByCountries : ForecastResponse, IGetWithPath
{
}