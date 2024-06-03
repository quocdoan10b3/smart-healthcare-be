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
    [HttpPost("add-medicine")]
    public async Task<IActionResult> AddMedicine(AddMedicineRequest request)
    {
        await _medicineService.AddMedicineAsync(request);
        return Ok();
    }
    [HttpPost("import-medicine")]
    public async Task<IActionResult> ImportMedicine(ImportMedicineRequest request)
    {
        await _medicineService.ImportMedicineAsync(request);
        return Ok();
    }
    [HttpGet("import-medicine")]
    public async Task<IActionResult> GetAllImportMedicines([FromQuery] HistoryImportRequest pqp)
    {
        var response = await _medicineService.GetAllImportMedicinesAsync(pqp);
        return Ok(response);
    }
    [HttpPost("import-new-medicine")]
    public async Task<IActionResult> ImportNewMedicine(ImportNewMedicineRequest request)
    {
        await _medicineService.ImportNewMedicineAsync(request);
        return Ok();
    }
}