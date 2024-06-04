namespace SmartHealthCare.Application.ViewModels.Statistics;

public class GetStatisticsResponse
{
    
    public int? ImportCount { get; set; }
    public int? ImportedTypeOfMedicineCount { get; set; }
    public int? ImportedMedicineCount { get; set; }
    public int? UsageMedicineStudentCount { get; set; }
    public int? UsageMedicinesCount { get; set; }
    public string? NameMedicineUsageMax { get; set; }
    public int? UsageTypeOfMedicineMax { get; set; }
}