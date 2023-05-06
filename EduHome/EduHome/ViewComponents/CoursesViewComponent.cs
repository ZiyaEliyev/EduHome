using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class CoursesViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public CoursesViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Course> courses = new List<Course>();
            if (take==0)
            {
                courses = await _db.Courses.OrderByDescending(x => x.Id).ToListAsync();
            }
            else
            {
                courses = await _db.Courses.OrderByDescending(x=>x.Id).Take(take).ToListAsync();
            }
            return View(courses);
           
        }
    }
}
