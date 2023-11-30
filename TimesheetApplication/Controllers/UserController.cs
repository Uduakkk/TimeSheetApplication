using Microsoft.AspNetCore.Mvc;

namespace TimesheetApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
