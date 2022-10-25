using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/currency")]
internal class GetMarketCurrencyCrosses : MarketsResponse, IGetWithQuery
{
}