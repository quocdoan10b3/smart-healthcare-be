using System.Runtime.InteropServices.JavaScript;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class Student : EntityBase
{
    public string StudentCode { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public string Class { get; set; } = String.Empty;
    public DateTime Date { get; set; } 
    public bool Gender { get; set; }
    public string? Address { get; set; } 
    public ICollection<FeedBack> FeedBacks = new List<FeedBack>();
    public HealthInsurance HealthInsurance { get; set; } = null!;
    public ICollection<History> Histories = new List<History>();
    public ICollection<HealthRecord> HealthRecords = new List<HealthRecord>();

}