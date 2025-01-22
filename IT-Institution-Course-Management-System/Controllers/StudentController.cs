using IT_Institution_Course_Management_System.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Institution_Course_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

      

            [HttpGet("get-all-students")]
            public async Task<IActionResult> GetAllStudents()
            {
                try
                {
                    var students = await _studentService.GetAllStudent();

                    if (students == null || !students.Any())
                    {
                        // No students found
                        return NotFound(new { message = "No students found please post student " });
                    }

                    return Ok(students);
                }
                catch (Exception ex)
                {
                    // Log the exception (if logging is configured)
                    Console.WriteLine($"Error: {ex.Message}");

                    // Return a generic error response
                    return StatusCode(500, new { message = "An error occurred while retrieving students.", details = ex.Message });
                }
            }
        }
    }


