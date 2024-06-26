using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.HealthRecord;
using SmartHealthCare.Domain;

namespace SmartHealthCare.Controllers;

[ApiController]
[Route("api/health-record")]
[Authorize]
public class HealthRecordController : ControllerBase
{
    private readonly HealthRecordService _healthRecordService;

    public HealthRecordController(HealthRecordService healthRecordService)
    {
        _healthRecordService = healthRecordService;
    }
    // [Authorize(Roles = "admin")]
    [HttpGet()]
    public async Task<IActionResult> GetAllHealthRecords([FromQuery] GetHealthRecordsRequest pqp)
    {
        var response = await _healthRecordService.GetAllHealthRecords(pqp);
        return Ok(response);
    }
    [HttpGet("{studentId:int}")]
    public async Task<IActionResult> GetHealthRecordByStudentId(int studentId)
    {
        var response = await _healthRecordService.GetHealthRecordByStudentId(studentId);
        return Ok(response);
    }
    [HttpGet("userId/{userId:int}")]
    public async Task<IActionResult> GetHealthRecordByUserId(int userId,[FromQuery] GetHealthRecordsRequest pqp)
    {
        var response = await _healthRecordService.GetHealthRecordByUserIdAsync(userId,pqp);
        return Ok(response);
    }
    // [Authorize(Roles = "admin, staff")]
    [HttpPost("{studentId:int}")]
    public async Task<IActionResult> CreateHealthInsuranceStudent(int studentId, AddHealthRecordRequest request)
    {
        await _healthRecordService.AddHealthRecordStudent(studentId,request);
        return Ok();
    }

    [HttpGet("{studentId:int}/is-examined/{currentYear:int}")]
    public async Task<IActionResult> CheckStudentIsExam(int studentId,int currentYear)
    {
        var result = await _healthRecordService.CheckStudentIsExamAsync(studentId,currentYear);
        return Ok(result);
    }
    [HttpGet("list-scholastic")]
    public async Task<IActionResult> GetAllScholasticYears()
    {
        var response = await _healthRecordService.GetAllScholasticYearsAsync();
        return Ok(response);
    }
    [HttpGet("list-scholastic/{userId:int}")]
    public async Task<IActionResult> GetAllScholasticYearsByUserId(int userId)
    {
        var response = await _healthRecordService.GetAllScholasticYearsByUserIdAsync(userId);
        return Ok(response);
    }
}