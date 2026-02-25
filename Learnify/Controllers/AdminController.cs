using Microsoft.AspNetCore.Mvc;

namespace Learnify.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}