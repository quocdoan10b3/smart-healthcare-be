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
    public async Task<IActionResult> GetUsageMedicines(int studentId)
    {
        var response = await _usageMedicineService.GetUsageMedicinesByStudentIdAsync(studentId);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> UsageMedicineByStudentId(int studentId , AddUsageMedicineRequest request)
    {
        await _usageMedicineService.UsageMedicineByStudentIdAsync(studentId, request);
        return Ok();
    }
}