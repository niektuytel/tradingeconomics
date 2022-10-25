using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Comtrade.Queries;

[ApiEndpoint("/comtrade/historical")]
internal class GetComtradeHistoricalSymbol : ComtradeResponse, IGetWithPath
{ }