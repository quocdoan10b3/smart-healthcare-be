namespace SmartHealthCare.Application.ViewModels.UsageMedicine;

public record AddUsageMedicineRequest(DateTime UsageDate,string Reason, List<AddPrescriptionRequest> AddPrescriptionRequests,int StaffId);
public record AddPrescriptionRequest(int MedicineId,int Quantity);