using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.HealthInsurance;
namespace SmartHealthCare.Controllers;


[ApiController]
[Route("api/health-insurance")]
public class HealthInsuranceController : ControllerBase
{
    private readonly HealthInsuranceService _healthInsuranceService;

    public HealthInsuranceController(HealthInsuranceService healthInsuranceService)
    {
        _healthInsuranceService = healthInsuranceService;
    }
    [HttpGet()]
    public async Task<IActionResult> GetAllHealthInsurance([FromQuery] GetHealthInsurancesRequest pqp)
    {
        var response = await _healthInsuranceService.GetAllHealthInsurance(pqp);
        return Ok(response);
    }

    [HttpGet("{studentId:int}")]
    public async Task<IActionResult> GetHealthInsuranceByStudentId(int studentId)
    {
        var response = await _healthInsuranceService.GetHealthInsuranceByStudentId(studentId);
        return Ok(response);
    }
    
}