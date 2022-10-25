using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.News.Queries;

[ApiEndpoint("/news")]
internal class GetNewsList : NewsResponse, IGetWithQuery
{
}