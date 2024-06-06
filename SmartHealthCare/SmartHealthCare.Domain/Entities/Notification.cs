using System.Runtime.InteropServices.JavaScript;
using SmartHealthCare.Domain.Entities.Base;

namespace SmartHealthCare.Domain.Entities;

public class Notification : EntityBase
{
    public string Title { get; set; } = String.Empty;
    public string? Content { get; set; } = String.Empty;
    public string? Image { get; set; } = String.Empty;
    public DateTime DateCreatAt { get; set; }
    public int StaffId { get; set; }
    public Staff Staff { get; set; } = null!;
}