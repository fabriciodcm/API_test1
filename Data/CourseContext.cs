using API_test1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_test1.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options) { 
        
        }

        public DbSet<Course> Courses { get; set; }
    }
}
