using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/intraday")]
internal class GetMarketIntraday : MarketsResponse, IGetWithPath
{
}