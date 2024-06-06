namespace SmartHealthCare.Application.ViewModels.HealthRecord;

public record AddHealthRecordRequest(DateTime ExamDate,int Height,int Weight,int Vision,string Hearing,string DentalHealth,string Allergies, string Notes, string Scholastic,int StaffId);