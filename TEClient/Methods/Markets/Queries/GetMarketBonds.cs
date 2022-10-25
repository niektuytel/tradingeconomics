using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/bond")]
internal class GetMarketBonds : MarketsResponse, IGet
{
}