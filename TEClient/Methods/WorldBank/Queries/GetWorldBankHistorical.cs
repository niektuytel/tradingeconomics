using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.WorldBank.Queries;

[ApiEndpoint("/worldBank/historical")]
internal class GetWorldBankHistorical : WorldBankResponse, IGetWithQuery
{
}