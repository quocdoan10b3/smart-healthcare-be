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
        var medicineImports = await _context.Set<MedicineImport>()
            .Where(mi => !request.From.HasValue || mi.ImportDate.Date >= request.From)
            .Where(mi => !request.To.HasValue || mi.ImportDate.Date <= request.To)
            .ToListAsync();
        result.ImportCount = medicineImports.Count;
        result.ImportedTypeOfMedicineCount = medicineImports.Select(mi => mi.MedicineId).Distinct().Count();
        result.ImportedMedicineCount = medicineImports.Select(m => m.Quantity).Sum();
        
        var histories = await _context.Set<History>()
            .Where(mi => !request.From.HasValue || mi.UsageDate.Date >= request.From)
            .Where(mi => !request.To.HasValue || mi.UsageDate.Date <= request.To)
            .ToListAsync();
        var historyIds = histories.Select(h => h.Id).ToList();
        
        var prescriptions = await _context.Set<Prescription>()
            .Where(p => historyIds.Contains(p.HistoryId))
            .ToListAsync();
        var medicineIds = prescriptions.Select(p => p.MedicineId).Distinct().ToList();
        
        var medicines = await _context.Set<Medicine>()
            .Where(m => medicineIds.Contains(m.Id))
            .ToListAsync();
        
        result.UsageMedicineStudentCount= histories.Select(h=> h.StudentId).Distinct().Count();
        result.TotalUsageMedicinesCount = prescriptions.Sum(p => p.Quantity);

        var topMedicines  = prescriptions
            .GroupBy(p => p.MedicineId)
            .Select(g => new
            {
                MedicineId = g.Key,
                TotalQuantity = g.Sum(p => p.Quantity)
            })
            .OrderByDescending(g => g.TotalQuantity)
            .Take(3)
            .ToList();
        result.TopMedicineUsages = topMedicines.Select(tm =>
        {
            var medicine = medicines.FirstOrDefault(m => m.Id == tm.MedicineId);
            return new MedicineUsage
            {
                MedicineId = tm.MedicineId,
                NameMedicine = medicine?.Name,
                TotalQuantity = tm.TotalQuantity
            };
        }).ToList();

        return Ok(result);
    }
}