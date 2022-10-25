using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/symbol")]
internal class GetMarketSymbols : MarketsResponse, IGetWithPath
{
}