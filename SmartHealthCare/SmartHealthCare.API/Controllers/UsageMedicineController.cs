using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.UsageMedicine;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/usage-medicines")]
[Authorize]
public class UsageMedicineController : ControllerBase
{
    private readonly UsageMedicineService _usageMedicineService;

    public UsageMedicineController(UsageMedicineService usageMedicineService)
    {
        _usageMedicineService = usageMedicineService;
    }
    [HttpGet()]
    public async Task<IActionResult> GetAllUsageMedicines([FromQuery] HistoryRequest  pqp)
    {
        var response = await _usageMedicineService.GetAllUsageMedicinesAsync(pqp);
        return Ok(response);
    }
    [HttpGet("{studentId:int}")]
    public async Task<IActionResult> GetUsageMedicines(int studentId, [FromQuery] HistoryRequest pqp)
    {
        var response = await _usageMedicineService.GetUsageMedicinesByStudentIdAsync(studentId,pqp);
        return Ok(response);
    }
    [HttpGet("userId/{userId:int}")]
    public async Task<IActionResult> GetUsageMedicinesByUserId(int userId, [FromQuery] HistoryRequest pqp)
    {
        var response = await _usageMedicineService.GetUsageMedicinesByUserIdAsync(userId,pqp);
        return Ok(response);
    }
    [HttpPost("{studentId:int}")]
    public async Task<IActionResult> UsageMedicineByStudentId(int studentId , AddUsageMedicineRequest request)
    {
        await _usageMedicineService.UsageMedicineByStudentIdAsync(studentId, request);
        return Ok();
    }
}