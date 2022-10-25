using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Ratings.Queries;

[ApiEndpoint("/ratings/historical")]
internal class GetHistoricalRatings : RatingsResponse, IGetWithPath
{
}