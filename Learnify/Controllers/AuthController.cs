using Learnify.DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learnify.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var admin = await _context.Admins
                .FirstOrDefaultAsync(x => x.Username == username && x.Password == password);

            if (admin != null)
            {
                HttpContext.Session.SetString("Admin", admin.Username);
                return RedirectToAction("Index", "Admin");
            }

            ViewBag.Error = "Login yoki parol xato!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Login");
        }
    }
}