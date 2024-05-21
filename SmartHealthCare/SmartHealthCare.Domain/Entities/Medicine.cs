using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class Medicine : EntityBase
{
    public string Name { get; set; } = String.Empty;
    public int Quantity { get; set; }
    public string Effect { get; set; } = String.Empty;
    // public DateTime ImportDate { get; set; }
    // public DateTime ExpDate { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}