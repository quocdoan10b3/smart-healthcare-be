using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class MedicineImport: EntityBase
{
    public int Quantity { get; set; }
    public DateTime ImportDate { get; set; }
    public DateTime ExpDate { get; set; }
    public int UsedCount { get; set; }
    public int MedicineId { get; set; }
    public Medicine Medicine { get; set; } = null!;
}