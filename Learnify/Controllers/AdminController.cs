using Microsoft.AspNetCore.Mvc;

namespace Learnify.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Messages()
        {
            return View();
        }
    }
}