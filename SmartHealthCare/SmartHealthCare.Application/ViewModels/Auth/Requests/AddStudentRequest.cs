namespace SmartHealthCare.Application.ViewModels.Auth.Requests;

public record AddStudentRequest(string Email, string Password, string FullName, string UserName,string AvatarUrl,string Class,bool Gender,DateTime DateOfBirth,string Address);