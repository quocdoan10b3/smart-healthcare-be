using AutoMapper;
using SmartHealthCare.Application.ViewModels.Student;

namespace SmartHealthCare.Application.ViewModels.Staff;

public class StaffResponse
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public bool Gender { get; set; }
    public string Address { get; set; } = String.Empty;
    public string FullName { get; set; } = String.Empty;
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.Staff, StaffResponse>()
            .ForMember(dto => dto.FullName, opt => opt.MapFrom(s => s.User.FullName));

    }
}