namespace SmartHealthCare.Application.ViewModels.Auth.Requests;

public record AddStaffRequest(string Email, string Password, string FullName, string UserName);
