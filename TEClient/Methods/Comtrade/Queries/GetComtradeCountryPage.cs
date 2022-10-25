using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Comtrade.Queries;

[ApiEndpoint("/comtrade/country")]
internal class GetComtradeCountryPage : ComtradeResponse, IGetWithPath
{
}