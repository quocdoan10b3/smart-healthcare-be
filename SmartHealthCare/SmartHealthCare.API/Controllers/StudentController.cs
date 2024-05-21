using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Student;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/student")]
// [Authorize]
public class StudentController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentController(StudentService studentService)
    {
        _studentService=studentService;
    }
    // [Authorize(Roles = "admin")]
    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAllStudents([FromQuery] GetStudentsRequest pqp)
    {
        var response = await _studentService.GetAllStudentsAsync(pqp);
        return Ok(response);
    }
    [HttpGet("userId/{userId:int}")]
    public async Task<IActionResult> GetStudentByUserId(int userId)
    {
        var response = await _studentService.GetStudentByUserId(userId);
        return Ok(response);
    }
}