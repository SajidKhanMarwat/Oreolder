using Microsoft.AspNetCore.Mvc;

namespace Oreolder.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login(string email, string password)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
