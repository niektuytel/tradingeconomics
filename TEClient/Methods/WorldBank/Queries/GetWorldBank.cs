using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.WorldBank.Queries;

[ApiEndpoint("/worldBank/categories")]
internal class GetWorldBank : WorldBankResponse, IGet
{
}