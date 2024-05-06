using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class Prescription : EntityBase
{
    public int HistoryId { get; set; }
    public History History { get; set; } = null!;
    public int MedicineId { get; set; }
    public Medicine Medicine { get; set; } = null!;
    public int Quantity { get; set; }
    
}