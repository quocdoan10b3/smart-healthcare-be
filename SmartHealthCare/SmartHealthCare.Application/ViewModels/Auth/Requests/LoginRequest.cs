namespace SmartHealthCare.Application.ViewModels.Auth.Requests;

public record LoginRequest(string Identifier, string Password);
public record ResetPasswordRequest(string UserName,string Email,string FullName);
