using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
