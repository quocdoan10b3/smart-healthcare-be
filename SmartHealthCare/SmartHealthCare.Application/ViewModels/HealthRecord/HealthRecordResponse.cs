using AutoMapper;
namespace SmartHealthCare.Application.ViewModels.HealthRecord;

public class HealthRecordResponse
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public DateTime ExamDate { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Vision { get; set; }
    public string Hearing { get; set; } = null!;
    public string DentalHealth { get; set; } = null!;
    public string Allergies { get; set; } = null!;
    public string Notes { get; set; } = null!;
    public string StudentName { get; set; } = null!;
    public string Scholastic { get; set; } = null!;
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.HealthRecord, HealthRecordResponse>()
            .ForMember(dto => dto.StudentName, opt => opt.MapFrom(h => h.Student.User.FullName));
    }
}