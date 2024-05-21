using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Medicine;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/medicine")]
[Authorize]
public class MedicineController : ControllerBase
{
    private readonly MedicineService _medicineService;

    public MedicineController(MedicineService medicineService)
    {
        _medicineService = medicineService;
    }
    [HttpGet()]
    public async Task<IActionResult> GetAllMedicines([FromQuery] MedicineRequest pqp)
    {
        var response = await _medicineService.GetAllMedicinesAsync(pqp);
        return Ok(response);
    }
    // [Authorize(Roles = "admin")]
    [HttpPost("add-medicine")]
    public async Task<IActionResult> AddMedicine(AddMedicineRequest request)
    {
        await _medicineService.AddMedicineAsync(request);
        return Ok();
    }
    // [Authorize(Roles = "admin")]
    [HttpPost("use-medicine")]
    public async Task<IActionResult> UseMedicine(SubMedicineRequest request)
    {
        await _medicineService.SubMedicineAsync(request);
        return Ok();
    }
}