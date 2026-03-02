using Microsoft.AspNetCore.Mvc;

namespace Learnify.Controllers
{
    public class ContactController1 : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            ViewBag.Success = "Xabaringiz yuborildi ✅";
            return View();
        }
    }
}
