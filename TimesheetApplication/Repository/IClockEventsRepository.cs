using TimesheetApplication.DB.Entities;
using TimesheetApplication.Models;

namespace TimesheetApplication.Repository
{
    public interface IClockEventsRepository
    {
        ClockEvents WriteClockToJson(ClockEvents clockEvents);
        List<TimeEntry> GetClockEventsByUserName(string userName);
    }
}
