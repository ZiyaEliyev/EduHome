using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        } 
        public IActionResult Register()
        {
            return View();
        }
    }
}
