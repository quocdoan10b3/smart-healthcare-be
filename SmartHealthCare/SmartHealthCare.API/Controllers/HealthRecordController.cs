using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.HealthRecord;

namespace SmartHealthCare.Controllers;

[ApiController]
[Route("api/health-record")]
public class HealthRecordController : ControllerBase
{
    private readonly HealthRecordService _healthRecordService;

    public HealthRecordController(HealthRecordService healthRecordService)
    {
        _healthRecordService = healthRecordService;
    }
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

    [HttpPost("{studentId:int}")]
    public async Task<IActionResult> CreateHealthInsuranceStudent(int studentId, AddHealthRecordRequest request)
    {
        await _healthRecordService.AddHealthRecordStudent(studentId,request);
        return Ok();
    }
}