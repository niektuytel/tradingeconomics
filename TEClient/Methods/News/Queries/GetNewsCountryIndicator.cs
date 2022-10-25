using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.News.Queries;

[ApiEndpoint("/news/country")]
internal class GetNewsCountryIndicator : NewsResponse, IGetWithPath
{
}