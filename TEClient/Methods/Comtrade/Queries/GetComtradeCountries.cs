using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Comtrade.Queries;

[ApiEndpoint("/comtrade/countries")]
internal class GetComtradeCountries : ComtradeResponse, IGet
{
}