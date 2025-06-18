using Microsoft.AspNetCore.Mvc;
using IMS.Models;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace IMS.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "admin123")
                {
                    // Create user identity and sign in
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Username)
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = true // keeps user logged in until cookie expires
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("Index", "Dashboard");
                }

                ModelState.AddModelError(string.Empty, "Invalid username or password.");
            }

            return View(model);
        }
    }
}
