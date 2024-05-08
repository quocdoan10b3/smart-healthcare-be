namespace SmartHealthCare.Application.ViewModels.Auth.Requests;

public record AddHealthInsuranceRequest(string InsuranceNumber, DateTime ExpDate, bool Status);