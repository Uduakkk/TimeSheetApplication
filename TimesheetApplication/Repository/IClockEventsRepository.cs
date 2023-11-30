using TimesheetApplication.Models;

namespace TimesheetApplication.Repository
{
    public interface IClockEventsRepository
    {
        void WriteClockToJson(ClockEvents clockEvents);
    }
}
