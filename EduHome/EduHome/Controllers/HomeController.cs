using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _db.Sliders.ToList();
            List<Service> services = _db.Services.ToList();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Services = services

            };
            return View(homeVM);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
