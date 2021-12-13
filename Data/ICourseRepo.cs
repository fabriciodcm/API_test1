using API_test1.Models;

namespace API_test1.Data
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetCourses();
        Course GetCourseById(int id);
        Course GetCourseByName(string courseName);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int id);
        bool CreateCourse(Course course);
    }
}
