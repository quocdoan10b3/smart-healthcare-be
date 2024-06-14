namespace SmartHealthCare.Application.ViewModels.Staff;

public class UpsertStaffRequest
{
    public string Address { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public bool Gender { get; set; }
}