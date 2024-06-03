namespace SmartHealthCare.Application.ViewModels.Medicine;

public record ImportMedicineRequest(int Quantity, DateTime ImportDate,DateTime ExpDate,int MedicineId);
public record ImportNewMedicineRequest(string NameMedicine, string Effect, string ImageMedicine,int Quantity, DateTime ImportDate,DateTime ExpDate);