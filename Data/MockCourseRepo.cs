using API_test1.Models;

namespace API_test1.Data
{
    public class MockCourseRepo : ICourseRepo
    {
        public bool CreateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int id)
        {
            return new Course() { CourseId = 1, CourseName = "Panificação", CreationDate = DateTime.Now, Syllabus = "Noções básicas de panificação" };
        }

        public Course GetCourseByName(string courseName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourses()
        {
            return new List<Course>()
            {
                new Course(){ CourseId = 1, CourseName = "Panificação", CreationDate = DateTime.Now , Syllabus = "Noções básicas de panificação"},
                new Course(){ CourseId = 2, CourseName = "Confeitaria", CreationDate = DateTime.Now , Syllabus = "Noções básicas de confeitaria"}
            };
        }

        public bool UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
