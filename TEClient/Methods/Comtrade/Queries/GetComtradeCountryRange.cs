using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Comtrade.Queries;

[ApiEndpoint("/comtrade/country")]
internal class GetComtradeCountryRange : ComtradeResponse, IGetWithPath
{ }