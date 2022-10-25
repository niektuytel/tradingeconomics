using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/historical")]
internal class GetMarketHistoricalBySymbol : MarketsResponse, IGetWithPath
{
}