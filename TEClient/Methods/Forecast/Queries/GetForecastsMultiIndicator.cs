using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Forecast.Queries;

[ApiEndpoint("/forecast/indicator")]
internal class GetForecastsMultiIndicator : ForecastResponse, IGetWithPath
{
}