using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
