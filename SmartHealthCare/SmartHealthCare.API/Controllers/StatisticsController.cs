using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.ViewModels.Statistics;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Infrastructure.Data;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/statistics")]
public class StatisticsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StatisticsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetStatisticsRequest request)
    {
        var result = new GetStatisticsResponse();
        var medicineImport = await _context.Set<MedicineImport>()
            .Where(mi => !request.From.HasValue || mi.ImportDate >= request.From)
            .Where(mi => !request.To.HasValue || mi.ImportDate <= request.To)
            .ToListAsync();
        result.ImportCount = medicineImport.Count;
        result.ImportedTypeOfMedicineCount = medicineImport.Select(mi => mi.MedicineId).Distinct().Count();
        result.ImportedMedicineCount = medicineImport.Select(m => m.Quantity).Sum();
        var history = await _context.Set<History>()
            .Where(mi => !request.From.HasValue || mi.UsageDate >= request.From)
            .Where(mi => !request.To.HasValue || mi.UsageDate <= request.To)
            .ToListAsync();
        // result.UsageMedicinesCount;
        result.UsageMedicineStudentCount= history.Select(h=> h.StudentId).Distinct().Count();
        // result.UsageTypeOfMedicineMax;
        // result.NameMedicineUsageMax;
        return Ok(result);
    }
}