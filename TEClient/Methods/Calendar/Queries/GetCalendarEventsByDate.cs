using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Calendar.Queries;

[ApiEndpoint("/calendar/country/all")]
internal class GetCalendarEventsByDate : CalendarResponse, IGetWithPath
{
}