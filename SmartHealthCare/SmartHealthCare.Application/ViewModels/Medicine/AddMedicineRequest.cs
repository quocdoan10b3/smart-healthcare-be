namespace SmartHealthCare.Application.ViewModels.Medicine;

public record AddMedicineRequest(string Name, int Quantity, string Effect, DateTime ImportDate,DateTime ExpDate);