using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.WorldBank.Queries;

[ApiEndpoint("/worldBank/category")]
internal class GetWorldBankCategory : WorldBankResponse, IGetWithPath
{
}