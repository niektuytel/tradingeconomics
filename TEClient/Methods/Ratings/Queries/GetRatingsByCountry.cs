using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Ratings.Queries;

[ApiEndpoint("/ratings")]
internal class GetRatingsByCountry : RatingsResponse, IGetWithPath
{
}