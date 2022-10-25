using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.Calendar.Queries;

[ApiEndpoint("/calendar")]
internal class GetCalendarEvents : CalendarResponse, IGet
{ }