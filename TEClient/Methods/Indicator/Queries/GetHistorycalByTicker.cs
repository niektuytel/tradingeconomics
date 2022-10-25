using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Indicator.Queries;

[ApiEndpoint("/historical/ticker")]
internal class GetHistorycalByTicker : IndicatorResponse, IGetWithPath
{ }