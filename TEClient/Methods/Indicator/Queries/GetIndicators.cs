using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Indicator.Queries;

[ApiEndpoint("/indicators")]
internal class GetIndicators : IndicatorResponse, IGet
{
}