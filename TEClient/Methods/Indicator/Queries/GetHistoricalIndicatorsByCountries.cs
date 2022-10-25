using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Indicator.Queries;

[ApiEndpoint("/historical/country")]
internal class GetHistoricalIndicatorsByCountries : IndicatorResponse, IGetWithPath
{ }