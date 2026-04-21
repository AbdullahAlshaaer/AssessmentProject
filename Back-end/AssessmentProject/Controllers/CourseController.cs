using AssessmentProject.Models;
using AssessmentProject.Repositories.CustomRepo.CourseRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepo _course;
        public CourseController(ICourseRepo course)
        {
            _course = course;    
        }
        [HttpGet("GetAllCourses")]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _course.GetAll();
            if(courses == null)
            {
                return NoContent();
            }
            return Ok(courses);
        }
        [HttpGet("FilterCoursesByGrade")]
        public async Task<IActionResult> FilterCoursesByGrade(long GradeId)
        {
            var filteredCourses = await _course.FilterByGradeLevel(GradeId);
            if (filteredCourses == null)
                return NoContent();
            return Ok(filteredCourses);
        }
    }
}
