using Microsoft.AspNetCore.Mvc;

namespace Projet_PFA.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
