using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/index")]
internal class GetMarketIndex : MarketsResponse, IGet
{
}