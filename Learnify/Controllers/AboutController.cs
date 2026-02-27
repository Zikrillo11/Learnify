using Microsoft.AspNetCore.Mvc;

namespace Learnify.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}