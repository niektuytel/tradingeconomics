using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Ratings.Queries;

[ApiEndpoint("/ratings")]
internal class GetRatingsByCountries : RatingsResponse, IGetWithPath
{
}