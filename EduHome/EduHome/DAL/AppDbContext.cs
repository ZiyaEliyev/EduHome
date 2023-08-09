using EduHome.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
