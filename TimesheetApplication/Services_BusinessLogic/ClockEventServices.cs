using TimesheetApplication.Models;
using TimesheetApplication.Repository;

namespace TimesheetApplication.Services_BusinessLogic
{
    public class ClockEventServices : IClockEventServices
    {
        private readonly IClockEventsRepository _clockEventsRepository;
        private readonly IUserRepository _userRepository;

        public ClockEventServices(IClockEventsRepository clockEventsRepository, IUserRepository userRepository)
        {
            _clockEventsRepository = clockEventsRepository;
            _userRepository = userRepository;
        }
        public ClockEvents ClockIn(Guid userId)
        {
            var user = _userRepository.GetUserById(userId);

            if (user == null)
            {
                return RedirectToActionResult("Error");
            }

            var clockEvent = new ClockEvents()
            {
                UserId = user.Id,
                Username = user.UserName,
                Time = DateTime.Now,
                EventType = "ClockIn"
            };

            _clockEventsRepository.WriteClockToJson(clockEvent);
            return clockEvent;
        }

        public ClockEvents ClockOut(Guid userId)
        {
            var user = _userRepository.GetUserById(userId);

            if (user == null)
            {
                return RedirectToActionResult("Error");
            }

            var clockEvent = new ClockEvents()
            {
                
                UserId = user.Id,
                Username = user.UserName,
                Time = DateTime.Now,
                EventType = "ClockOut"
            };

            _clockEventsRepository.WriteClockToJson(clockEvent);
            return clockEvent;
        }
        private ClockEvents RedirectToActionResult(string v)
        {
            throw new NotImplementedException();
        }
    }
}
