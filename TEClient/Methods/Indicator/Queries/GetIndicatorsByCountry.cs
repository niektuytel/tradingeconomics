using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Indicator.Queries;

[ApiEndpoint("/country")]
internal class GetIndicatorsByCountry : IndicatorResponse, IGetWithPath
{ }