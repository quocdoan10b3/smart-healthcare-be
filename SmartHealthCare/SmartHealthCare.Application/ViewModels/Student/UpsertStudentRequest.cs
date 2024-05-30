namespace SmartHealthCare.Application.ViewModels.Student;

public class UpsertStudentRequest
{
    public string Class { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public bool Gender { get; set; }
    
}