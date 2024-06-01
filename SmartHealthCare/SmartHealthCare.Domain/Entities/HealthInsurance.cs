using System.ComponentModel.DataAnnotations;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class HealthInsurance : EntityBase
{
    public string InsuranceNumber { get; set; } = String.Empty;
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public DateTime ExpDate { get; set; }
    public bool Status { get; set; }
    public string Scholastic { get; set; } = String.Empty;
}