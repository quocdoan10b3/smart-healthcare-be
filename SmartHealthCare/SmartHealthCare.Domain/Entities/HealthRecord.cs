using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class HealthRecord : EntityBase
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public DateTime ExamDate { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Vision { get; set; }
    public string Hearing { get; set; } = String.Empty;
    public string DentalHealth { get; set; } = String.Empty;
    public string Allergies { get; set; } = String.Empty;
    public string Notes { get; set; } = String.Empty;
}