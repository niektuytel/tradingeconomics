using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Ratings.Queries;

[ApiEndpoint("/ratings")]
internal class GetRatings : RatingsResponse, IGet
{
}