using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Forecast.Queries;

[ApiEndpoint("/forecast/indicator")]
internal class GetForecastsByIndicator : ForecastResponse, IGetWithPath
{
}