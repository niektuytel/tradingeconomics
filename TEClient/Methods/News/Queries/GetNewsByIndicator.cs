using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.News.Queries;

[ApiEndpoint("/news/indicator")]
internal class GetNewsByIndicator : NewsResponse, IGetWithPath
{
}