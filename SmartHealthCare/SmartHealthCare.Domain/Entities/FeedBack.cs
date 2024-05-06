using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class FeedBack : EntityBase
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public float Rating { get; set; }
    public string Comments { get; set; } = String.Empty;
}