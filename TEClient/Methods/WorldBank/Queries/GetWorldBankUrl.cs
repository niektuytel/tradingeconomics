using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.WorldBank.Queries;

[ApiEndpoint("/worldBank/indicator")]
internal class GetWorldBankUrl : WorldBankResponse, IGetWithQuery
{
}