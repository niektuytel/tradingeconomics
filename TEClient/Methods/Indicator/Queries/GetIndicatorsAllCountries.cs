using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Indicator.Queries;

[ApiEndpoint("/country/all")]
internal class GetIndicatorsAllCountries : IndicatorResponse, IGetWithPath
{ }