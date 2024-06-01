using System.ComponentModel.DataAnnotations;
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
    [MaxLength(100)]
    public string Hearing { get; set; } = String.Empty;
    [MaxLength(100)]
    public string DentalHealth { get; set; } = String.Empty;
    [MaxLength(100)]
    public string Allergies { get; set; } = String.Empty;
    [MaxLength(100)]
    public string Notes { get; set; } = String.Empty;
    [MaxLength(20)]
    public string Scholastic { get; set; } = String.Empty;
}