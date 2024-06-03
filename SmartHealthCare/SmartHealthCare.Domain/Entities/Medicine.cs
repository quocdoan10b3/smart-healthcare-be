using System.ComponentModel.DataAnnotations;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class Medicine : EntityBase
{
    public string Name { get; set; } = String.Empty;
    public string Effect { get; set; } = String.Empty;
    public string? ImageMedicine { get; set; }
    public List<MedicineImport> MedicineImports { get; set; } = new List<MedicineImport>();
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}