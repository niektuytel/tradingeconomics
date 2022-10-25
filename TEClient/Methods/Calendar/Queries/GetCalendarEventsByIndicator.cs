using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Calendar.Queries;

[ApiEndpoint("/calendar/indicator")]
internal class GetCalendarEventsByIndicator : CalendarResponse, IGetWithPath
{ }