using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.News.Queries;

[ApiEndpoint("/news/country")]
internal class GetNewsByCountry : NewsResponse, IGetWithPath
{
}