using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Calendar.Queries;

[ApiEndpoint("/calendar/calendarid")]
internal class GetCalendarEventsById : CalendarResponse, IGetWithPath
{ }