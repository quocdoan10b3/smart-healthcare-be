using AutoMapper;
using SmartHealthCare.Application.ViewModels.Medicine;
using SmartHealthCare.Application.ViewModels.Prescription;

namespace SmartHealthCare.Application.ViewModels.UsageMedicine;

public class HistoryResponse
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public DateTime UsageDate { get; set; }
    public string Reason { get; set; } = null!;
    public string StudentName { get; set; } = null!;
    public string ClassStudent { get; set; } = null!;
    public List<PrescriptionResponse> PrescriptionResponses { get; set; } = new List<PrescriptionResponse>();
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.History, HistoryResponse>()
            .ForMember(dto => dto.StudentName, opt => opt.MapFrom(h => h.Student.User.FullName))
            .ForMember(dto => dto.PrescriptionResponses, opt => opt.MapFrom(h => h.Prescriptions))
            .ForMember(dto => dto.ClassStudent, opt => opt.MapFrom(h=> h.Student.Class));
    }
}