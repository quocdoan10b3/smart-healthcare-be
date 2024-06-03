using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Auth.Requests;
using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain;

namespace SmartHealthCare.Controllers;

[ApiController]
[Route("api/health-insurance")]
[Authorize]
public class HealthInsuranceController : ControllerBase
{
    private readonly HealthInsuranceService _healthInsuranceService;

    public HealthInsuranceController(HealthInsuranceService healthInsuranceService)
    {
        _healthInsuranceService = healthInsuranceService;
    }
    [Authorize(Roles = AppRole.Admin)]
    [HttpGet()]
    public async Task<IActionResult> GetAllHealthInsurance([FromQuery] GetHealthInsurancesRequest pqp)
    {
        // Console.WriteLine("valueeeeeeeeeeeeeeeee: {0}", AppRole.Admin);
        var response = await _healthInsuranceService.GetAllHealthInsurance(pqp);
        return Ok(response);
    }

    [HttpGet("{studentId:int}")]
    public async Task<IActionResult> GetHealthInsuranceByStudentId(int studentId)
    {
        var response = await _healthInsuranceService.GetHealthInsuranceByStudentId(studentId);
        return Ok(response);
    }
    [Authorize(Roles = AppRole.Admin)]
    [HttpPost("{studentId:int}")]
    public async Task<IActionResult> CreateHealthInsuranceStudent(int studentId, AddHealthInsuranceRequest request)
    {
        await _healthInsuranceService.AddHealthInsuranceStudent(studentId,request);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStatusHealthInsurance(int id,
        [FromBody] UpsertHealthInsuranceRequest request)
    {
        await _healthInsuranceService.UpdateStatusHealthInsuranceAsync(id,request);
        return Ok();
    }
    [HttpGet("{studentId:int}/is_health_insurance/{currentYear:int}")]
    public async Task<IActionResult> CheckHealthInsuranceStudent(int studentId,int currentYear)
    {
        var result = await _healthInsuranceService.CheckStudentHasHealthInsuranceAsync(studentId,currentYear);
        return Ok(result);
    }
    [HttpGet("list-scholastic")]
    public async Task<IActionResult> GetAllScholasticYears()
    {
        var response = await _healthInsuranceService.GetAllScholasticYearsAsync();
        return Ok(response);
    }
}