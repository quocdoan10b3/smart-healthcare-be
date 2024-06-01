using System.ComponentModel.DataAnnotations;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class History : EntityBase
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public DateTime UsageDate { get; set; }
    [MaxLength(100)]
    public string Reason { get; set; } = String.Empty;
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}