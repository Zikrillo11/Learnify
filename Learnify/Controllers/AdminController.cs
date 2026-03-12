using Learnify.DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learnify.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Admin/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Admin/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var admin = _context.Admins
                .FirstOrDefault(a => a.Username == username && a.Password == password);

            if (admin != null)
            {
                // Session ga saqlash
                HttpContext.Session.SetString("AdminUsername", admin.Username);

                return RedirectToAction("Index"); // ⚠️ shu yerda Dashboard emas, Index
            }

            ViewBag.Error = "Username yoki password xato!";
            return View();
        }

        // GET: /Admin/Index
        public IActionResult Index()
        {
            var adminUsername = HttpContext.Session.GetString("AdminUsername");
            if (string.IsNullOrEmpty(adminUsername))
                return RedirectToAction("Login");

            ViewBag.AdminUsername = adminUsername;
            return View(); // ⚠️ Views/Admin/Index.cshtml ishlaydi
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminUsername");
            return RedirectToAction("Login");
        }
    }
}