namespace SmartHealthCare.Application.ViewModels.HealthInsurance;

public record AddHealthInsuranceRequest(string InsuranceNumber, DateTime ExpDate, bool Status, string Scholastic);