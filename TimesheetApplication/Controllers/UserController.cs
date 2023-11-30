using Microsoft.AspNetCore.Mvc;
using TimesheetApplication.Models;
using TimesheetApplication.Services_BusinessLogic;

namespace TimesheetApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _services;

        public UserController(IUserServices services)
        {
            _services = services;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUser createUser)
        {
            
                CreateUser user = _services.RegisterUser(createUser);
                return View(user);
           
        }
    }
}
