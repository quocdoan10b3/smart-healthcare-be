namespace SmartHealthCare.Application.ViewModels.Medicine;

public record ImportMedicineRequest(int Quantity, DateTime ImportDate,DateTime ExpDate,int MedicineId);