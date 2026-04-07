using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class AdminController : Controller
{
    // LOGIN PAGE (GET)
    [HttpGet]    
    public IActionResult Login()
    {
        return View();    
    } 

    // LOGIN (POST)
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == "Learnify" && password == "0103")   
        {
            HttpContext.Session.SetString("Admin", username);
            return RedirectToAction("Index");   
        }    

        ViewBag.Error = "Login yoki parol xato!";   
        return View();
    }

    // ADMIN PANEL
    public IActionResult Index()
    {
        var admin = HttpContext.Session.GetString("Admin");

        if (admin == null)
            return RedirectToAction("Login");

        return View();
    }

    // LOGOUT
    public IActionResult Logout()
    {
        HttpContext.Session.Remove("Admin");
        return RedirectToAction("Login");
    }
}