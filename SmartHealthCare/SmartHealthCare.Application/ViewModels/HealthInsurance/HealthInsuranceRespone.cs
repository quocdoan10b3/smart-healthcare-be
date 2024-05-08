using AutoMapper;
namespace SmartHealthCare.Application.ViewModels.HealthInsurance;

public class HealthInsuranceRespone
{
    public int Id { get; set; }
    public string InsuranceNumber { get; set; } = null!;
    public string StudentName { get; set; }
    public int StudentId { get; set; } 
    public DateTime ExpDate { get; set; }
    public bool Status { get; set; }
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.HealthInsurance, HealthInsuranceRespone>()
            .ForMember(dto => dto.StudentName, opt => opt.MapFrom(h => h.Student.User.FullName));
    }
}