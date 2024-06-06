using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class Staff : EntityBase
{
    public int UserId { get; set; }
    
    public DateTime Date { get; set; }
    public bool Gender { get; set; }
    public string? Address { get; set; }
    public User User { get; set; } = null!;
    public ICollection<HealthInsurance> HealthInsurances = new List<HealthInsurance>();
    public ICollection<History> Histories = new List<History>();
    public ICollection<HealthRecord> HealthRecords = new List<HealthRecord>();
    public ICollection<Notification> Notifications = new List<Notification>();
    public ICollection<MedicineImport> MedicineImports = new List<MedicineImport>();
}