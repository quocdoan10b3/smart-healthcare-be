using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Staff;
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
    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetStaff(int userId)
    {
        var response = await _staffService.GetStaffByIdAsync(userId);
        return Ok(response);
    }
    [HttpPut()]
    public async Task<IActionResult> UpdateInfoStudent(int staffId, [FromBody] UpsertStaffRequest request)
    {
        await _staffService.UpdateInfoStaffAsync(staffId,request);
        return Ok();
    }
}