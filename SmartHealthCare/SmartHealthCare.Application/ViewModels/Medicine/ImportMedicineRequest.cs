namespace SmartHealthCare.Application.ViewModels.Medicine;

public record ImportMedicineRequest(int Quantity, DateTime ImportDate,DateTime ExpDate,int MedicineId,int StaffId);
public record ImportNewMedicineRequest(string NameMedicine, string Effect, string ImageMedicine,int Quantity, DateTime ImportDate,DateTime ExpDate, int StaffId);