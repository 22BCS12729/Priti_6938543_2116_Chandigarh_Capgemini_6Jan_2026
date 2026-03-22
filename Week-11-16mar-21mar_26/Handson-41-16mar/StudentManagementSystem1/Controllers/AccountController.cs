using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "123")
        {
            HttpContext.Session.SetString("user", username);
            return RedirectToAction("Dashboard");
        }

        ViewBag.Error = "Invalid Login";
        return View();
    }

    public IActionResult Dashboard()
    {
        if (HttpContext.Session.GetString("user") == null)
            return RedirectToAction("Login");

        ViewBag.User = HttpContext.Session.GetString("user");
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}