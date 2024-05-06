using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class History : EntityBase
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public DateTime UsageDate { get; set; }
    public string Reason { get; set; } = String.Empty;
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}