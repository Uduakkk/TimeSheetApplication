using TimesheetApplication.DB.WriteAndReadFromJson;
using TimesheetApplication.Models;

namespace TimesheetApplication.Repository
{
    public class ClockEventsRepository : IClockEventsRepository
    {
        private readonly WriteToJson _writeToJson;
        private readonly ReadFromJson _readFromJson;
        private readonly string userFileName = "clockEvents.json";

        public ClockEventsRepository(WriteToJson writeToJson, ReadFromJson readFromJson)
        {
            _writeToJson = writeToJson;
            _readFromJson = readFromJson;
        }

        public void WriteClockToJson(ClockEvents clockEvents)
        {
            try
            {
                _writeToJson.WriteClockEventsToJsons(clockEvents, userFileName);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
