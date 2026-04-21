using AssessmentProject.Repositories.CustomRepo.StudentRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _stu;
        public StudentController(IStudentRepo stu)
        {
            _stu = stu;
        }
        [HttpGet("GetAllStudents")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _stu.GetAll();
            if(students==null)
            {
                return NoContent();
            }
            return Ok(students);
        }
        //[HttpGet("GetStudentById{int:id}")]
        [HttpGet("StudentById")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _stu.GetById(id);
            if(student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
