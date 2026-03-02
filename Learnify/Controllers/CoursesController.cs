using Microsoft.AspNetCore.Mvc;

namespace Learnify.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}