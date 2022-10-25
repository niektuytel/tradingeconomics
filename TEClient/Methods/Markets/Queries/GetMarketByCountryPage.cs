using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Markets.Queries;

[ApiEndpoint("/markets/country")]
internal class GetMarketByCountryPage : MarketsResponse, IGetWithPathAndQuery
{
}