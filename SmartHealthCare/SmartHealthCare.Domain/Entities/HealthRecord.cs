using System.ComponentModel.DataAnnotations;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class HealthRecord : EntityBase
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public DateTime ExamDate { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }
    public int Vision { get; set; }
    [MaxLength(500)]
    public string Hearing { get; set; } = String.Empty;
    [MaxLength(500)]
    public string DentalHealth { get; set; } = String.Empty;
    public string Allergies { get; set; } = String.Empty;
    public string Notes { get; set; } = String.Empty;
    [MaxLength(20)]
    public string Scholastic { get; set; } = String.Empty;
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;
}