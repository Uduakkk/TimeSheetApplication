using TimesheetApplication.DB.Entities;
using TimesheetApplication.DB.WriteAndReadFromJson;
using TimesheetApplication.Models;

namespace TimesheetApplication.Repository
{
    public class ClockEventsRepository : IClockEventsRepository
    {
        private readonly WriteToJson _writeToJson;
        private readonly ReadFromJson _readFromJson;
        private readonly IUserRepository _userRepository;
        private readonly string userFileName = "clockEvents.json";

        public ClockEventsRepository(WriteToJson writeToJson, ReadFromJson readFromJson, IUserRepository userRepository)
        {
            _writeToJson = writeToJson;
            _readFromJson = readFromJson;
            _userRepository = userRepository;
        }

        public ClockEvents WriteClockToJson(ClockEvents clockEvents)
        {
            try
            {
                List<TimeEntry> listOfClockEvents = _readFromJson.ReadFromJsons<TimeEntry>(userFileName);

                var user = _userRepository.GetUserByUsername(clockEvents.Username);

                TimeEntry timeEntry = new TimeEntry()
                {
                    UserId = clockEvents.UserId,
                    Time = clockEvents.Time,
                    UserName = clockEvents.Username,
                    EventType  = clockEvents.EventType,
                    
                };

                listOfClockEvents.Add(timeEntry);

                _writeToJson.WriteToJsons<TimeEntry>(listOfClockEvents, userFileName);

                return clockEvents;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public List<TimeEntry> GetClockEventsByUserName (string userName)
        {
                List<TimeEntry> listOfClockEvents = _readFromJson.ReadFromJsons<TimeEntry>(userFileName);
                var userClockEvents = listOfClockEvents.Where(x => x.UserName == userName).ToList();
                
                 return userClockEvents;
        }
    }
}
