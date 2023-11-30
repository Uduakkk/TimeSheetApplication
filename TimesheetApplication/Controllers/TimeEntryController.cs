using Microsoft.AspNetCore.Mvc;
using TimesheetApplication.Repository;
using TimesheetApplication.Services_BusinessLogic;

namespace TimesheetApplication.Controllers
{
    public class TimeEntryController : Controller
    {
        private readonly IClockEventServices _clockEventServices;
        private readonly IUserRepository _userRepository;

        public TimeEntryController(IClockEventServices clockEventServices, IUserRepository userRepository)
        {
            _clockEventServices = clockEventServices;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
           // var user = _userRepository.GetUserById();
            //if (user == null)
            //{
            //    return RedirectToAction("Error");
            //}
            return View();
        }

        [HttpGet]
        public IActionResult ClockIn ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClockIn (string userName)
        {
            var user = _userRepository.GetUserByUsername (userName);
            if (user != null)
            {
                var userClockIn = _clockEventServices.ClockIn(user.Id);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult ClockOut(string userName)
        {
            var user = _userRepository.GetUserByUsername(userName);
            if (user != null)
            {
                var userClockOut = _clockEventServices.ClockIn(user.Id);
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
