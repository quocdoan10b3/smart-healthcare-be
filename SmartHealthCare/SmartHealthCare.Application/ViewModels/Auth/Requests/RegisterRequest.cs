namespace SmartHealthCare.Application.ViewModels.Auth.Requests;

public record RegisterRequest(string Email, string Password, string FullName, string UserName, string Role);
