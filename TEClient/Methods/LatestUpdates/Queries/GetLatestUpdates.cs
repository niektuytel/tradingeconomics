using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.LatestUpdates.Queries;

[ApiEndpoint("/updates")]
internal class GetLatestUpdates : LatestUpdatesResponse, IGet, IGetWithPath
{
}