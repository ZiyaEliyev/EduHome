using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
