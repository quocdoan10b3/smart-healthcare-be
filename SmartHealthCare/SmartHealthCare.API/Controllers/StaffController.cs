using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Staff;
using SmartHealthCare.Application.ViewModels.Student;
using SmartHealthCare.Domain;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/staff")]
public class StaffController : ControllerBase
{
    private readonly StaffService _staffService;

    public StaffController(StaffService staffService)
    {
        _staffService=staffService;
    }
    [Authorize(Roles = AppRole.Admin)]
    [HttpGet()]
    public async Task<IActionResult> GetAllStaffs([FromQuery] GetStaffRequest pqp)
    {
        var response = await _staffService.GetAllStaffsAsync(pqp);
        return Ok(response);
    }
}