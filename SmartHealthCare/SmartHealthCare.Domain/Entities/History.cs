using System.ComponentModel.DataAnnotations;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class History : EntityBase
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public DateTime UsageDate { get; set; }
    [MaxLength(5000)]
    public string Reason { get; set; } = String.Empty;
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}