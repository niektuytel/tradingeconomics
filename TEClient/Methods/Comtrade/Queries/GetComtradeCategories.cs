using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Comtrade.Queries;

[ApiEndpoint("/comtrade/categories")]
internal class GetComtradeCategories : ComtradeResponse, IGet
{
}