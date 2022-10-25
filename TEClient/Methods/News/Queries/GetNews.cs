using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.News.Queries;

[ApiEndpoint("/news")]
internal class GetNews : NewsResponse, IGet
{
}