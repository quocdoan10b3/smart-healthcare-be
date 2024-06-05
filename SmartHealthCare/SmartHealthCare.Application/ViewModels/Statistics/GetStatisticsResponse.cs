namespace SmartHealthCare.Application.ViewModels.Statistics;

public class GetStatisticsResponse
{
    
    public int? ImportCount { get; set; }
    public int? ImportedTypeOfMedicineCount { get; set; }
    public int? ImportedMedicineCount { get; set; }
    public int? UsageMedicineStudentCount { get; set; }
    public int? TotalUsageMedicinesCount { get; set; }

    public List<MedicineUsage> TopMedicineUsages { get; set; } = new List<MedicineUsage>();
}
public class MedicineUsage
{
    public int MedicineId { get; set; }
    public string NameMedicine { get; set; }
    public int TotalQuantity { get; set; }
}