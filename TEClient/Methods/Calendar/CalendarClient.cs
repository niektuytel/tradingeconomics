using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEClient.Methods.Calendar.Queries;
using TEClient.Methods.Earnings.Queries;
using TEClient.Methods.FederalReserve;
using TEClient.Methods.FederalReserve.Models;

namespace TEClient.Methods.Calendar;

public class CalendarClient : ApiBase
{
    public CalendarClient(string baseUrl="", string clientKey="") : base(baseUrl, clientKey)
    { }

    /// <summary>
    /// Get all calendar events without filters
    /// </summary>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEvents()
    {
        return Query<GetCalendarEvents>();
    }

    /// <summary>
    /// Get all calendar events between dates
    /// </summary>
    /// <param name="startDate">Begining of the period</param>
    /// <param name="endDate">End of the period</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsByDate(DateTime startDate, DateTime endDate)
    {
        if (
            startDate == DateTime.MinValue || 
            startDate == DateTime.MaxValue ||
            endDate == DateTime.MinValue || 
            endDate == DateTime.MaxValue
        ) {
            throw new NotSupportedException("Dates aren't properly defined");
        }
        
        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return Query<GetCalendarEventsByDate>($"/{textStartDate}/{textEndDate}");
    }

    /// <summary>
    /// Get calendar events for multiple countries
    /// </summary>
    /// <param name="countries">Array with the names of the requested countries</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsByCountries(params string[] countries)
    {
        foreach (var country in countries)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new NotSupportedException("Countries aren't properly defined");
            }
        }

        return Query<GetCalendarEventsByCountries>($"/{string.Join(",", countries)}");
    }

    /// <summary>
    /// Get calendar events between dates given a set of countries
    /// </summary>
    /// <param name="startDate">Begining of the period</param>
    /// <param name="endDate">End of the period</param>
    /// <param name="countries">Array with the names of the requested countries</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries)
    {
        if (
            startDate == DateTime.MinValue || 
            startDate == DateTime.MaxValue ||
            endDate == DateTime.MinValue || 
            endDate == DateTime.MaxValue
        ) {
            throw new NotSupportedException("Dates aren't properly defined");
        }

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        foreach (var country in countries)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new NotSupportedException("Countries aren't properly defined");
            }
        }

        return Query<GetCalendarEventsByCountries>($"/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    /// <summary>
    /// Get calendar events for multiple indicators
    /// </summary>
    /// <param name="indicators">Array with the names of the requested indicators</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsByIndicator(params string[] indicators)
    {
        foreach (var indicator in indicators)
        {
            if (string.IsNullOrWhiteSpace(indicator))
            {
                throw new NotSupportedException("Indicatores aren't properly defined");
            }
        }

        return Query<GetCalendarEventsByIndicator>($"/{string.Join(",", indicators)}");
    }

    /// <summary>
    /// Get calendar events for multiple indicators between dates
    /// </summary>
    /// <param name="startDate">Begining of the period</param>
    /// <param name="endDate">End of the period</param>
    /// <param name="indicators">Array with the names of the requested indicators</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsByIndicatorAndDates(DateTime startDate, DateTime endDate, params string[] indicators)
    {
        if (
            startDate == DateTime.MinValue ||
            startDate == DateTime.MaxValue ||
            endDate == DateTime.MinValue ||
            endDate == DateTime.MaxValue
        )
        {
            throw new NotSupportedException("Dates aren't properly defined");
        }

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        foreach (var indicator in indicators)
        {
            if (string.IsNullOrWhiteSpace(indicator))
            {
                throw new NotSupportedException("Countries aren't properly defined");
            }
        }

        return Query<GetCalendarEventsByIndicator>($"/{string.Join(",", indicators)}/{textStartDate}/{textEndDate}");
    }

    /// <summary>
    /// Get calendar events for multiple countries and indicators between dates
    /// </summary>
    /// <param name="startDate">Begining of the period</param>
    /// <param name="endDate">End of the period</param>
    /// <param name="countries">Array with the names of the requested countries</param>
    /// <param name="indicators">Array with the names of the requested indicators</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsByIndicatorCountriesAndDates(DateTime startDate, DateTime endDate, string[] countries, params string[] indicators)
    {
        if (
            startDate == DateTime.MinValue ||
            startDate == DateTime.MaxValue ||
            endDate == DateTime.MinValue ||
            endDate == DateTime.MaxValue
        )
        {
            throw new NotSupportedException("Dates aren't properly defined");
        }

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        foreach (var indicator in indicators)
        {
            if (string.IsNullOrWhiteSpace(indicator))
            {
                throw new NotSupportedException("Indicators aren't properly defined");
            }
        }

        foreach (var country in countries)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new NotSupportedException("Countries aren't properly defined");
            }
        }

        return Query<GetCalendarEventsByCountries>($"/{string.Join(",", countries)}/indicator/{string.Join(",", indicators)}/{textStartDate}/{textEndDate}");
    }

    /// <summary>
    /// Get calendar events given the calendar ID
    /// </summary>
    /// <param name="ids">Array with the requested ids</param>
    /// <returns>A task that will be resolved in a string with the request result</returns>
    public IEnumerable<CalendarResponse> GetEventsById(params int[] ids)
    {
        return Query<GetCalendarEventsById>($"/{string.Join(",", ids)}");
    }
}
