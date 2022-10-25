using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/commodities")]
public class GetMarketCommodities : MarketsResponse, IGet
{
}