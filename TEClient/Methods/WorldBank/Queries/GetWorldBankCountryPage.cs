using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.WorldBank.Queries;

[ApiEndpoint("/worldBank/country")]
internal class GetWorldBankCountryPage : WorldBankResponse, IGetWithPath
{
}