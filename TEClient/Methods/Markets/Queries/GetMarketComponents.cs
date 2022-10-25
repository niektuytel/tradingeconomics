using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/components")]
internal class GetMarketComponents : MarketsResponse, IGetWithPath
{
}