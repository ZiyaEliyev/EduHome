using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
