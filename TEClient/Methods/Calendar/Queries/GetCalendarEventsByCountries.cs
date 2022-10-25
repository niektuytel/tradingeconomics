using TEClient.Attributes;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Calendar.Queries;

[ApiEndpoint("/calendar/country")]
internal class GetCalendarEventsByCountries : CalendarResponse, IGetWithPath
{

}