using TimesheetApplication.Models;

namespace TimesheetApplication.Services_BusinessLogic
{
    public interface IClockEventServices
    {
        ClockEvents ClockIn(Guid userId);
        ClockEvents ClockOut(Guid userId);
    }
}
