using API_test1.Data;
using API_test1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepo _repository;

        public CoursesController(ICourseRepo repository) {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAllCourses() { 
            var course = _repository.GetCourses();
            return Ok(course);
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetCourseById([FromRoute]int id)
        {
            var courses = _repository.GetCourseById(id);
            return Ok(courses);
        }
    }
}
