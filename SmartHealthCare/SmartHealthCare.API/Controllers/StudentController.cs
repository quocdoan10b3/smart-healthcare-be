using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Student;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/student")]
public class StudentController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentController(StudentService studentService)
    {
        _studentService=studentService;
    }
    [HttpGet()]
    public async Task<IActionResult> GetAllStudents([FromQuery] GetStudentsRequest pqp)
    {
        var response = await _studentService.GetAllStudentsAsync(pqp);
        return Ok(response);
    }
}