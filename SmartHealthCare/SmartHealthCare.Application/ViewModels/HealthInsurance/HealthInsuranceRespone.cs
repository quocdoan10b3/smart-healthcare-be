using AutoMapper;
using SmartHealthCare.Application.ViewModels.Auth.Responses;
using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Application.ViewModels.HealthInsurance;

public class HealthInsuranceRespone
{
    public int Id { get; set; }
    public string InsuranceNumber { get; set; } = null!;
    public string Name;
    public int StudentId { get; set; } 
    public DateTime ExpDate { get; set; }
    public bool Status { get; set; }
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.HealthInsurance, Domain.Entities.HealthInsurance>();
        CreateMap<Domain.Entities.HealthInsurance, HealthInsuranceRespone>()
            .ForMember(dto => dto.Name, opt => opt.MapFrom(h => h.Student.User.FullName));
    }
}