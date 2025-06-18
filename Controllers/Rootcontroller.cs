using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers
{
    public class RootController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
