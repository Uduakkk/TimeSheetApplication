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

        [HttpGet]
        public IActionResult ClockOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClockOut(string userName)
        {
            var user = _userRepository.GetUserByUsername(userName);
            if (user != null)
            {
                var userClockOut = _clockEventServices.ClockOut(user.Id);
                return RedirectToAction("Index");

            }

            return View();
        }

        [HttpGet]

        public IActionResult UserEntriesRequest()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult UserEntriesRequest(string userName)
        {
            var user = _userRepository.GetUserByUsername(userName);
            if (user != null)
            {
                TempData["userName"] = user.UserName;
                return RedirectToAction("GetClockEntries");

            }
            return View();
        }


        [HttpGet]
        public IActionResult GetClockEntries(string userName)
        {
            string UserName = TempData["userName"] as string;
            userName = UserName;
            var userClockEntries = _clockEventServices.userEntries(userName);
            return View(userClockEntries);
        }
    }
}
