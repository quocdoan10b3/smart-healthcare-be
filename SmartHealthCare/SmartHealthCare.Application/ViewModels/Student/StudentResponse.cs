using AutoMapper;

namespace SmartHealthCare.Application.ViewModels.Student;

public class StudentResponse
{
    public int Id { get; set; }
    public string StudentCode { get; set; } = null!;
    public string StudentName { get; set; } = null!;
    public int UserId { get; set; }
    public string Class { get; set; } = String.Empty;
    public DateTime Date { get; set; } 
    public bool Gender { get; set; }
    public string Address { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string AvatarUrl { get; set; } = null!;
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.Student, StudentResponse>()
            .ForMember(dto => dto.StudentName, opt => opt.MapFrom(s => s.User.FullName))
            .ForMember(dto => dto.Email, opt => opt.MapFrom(s => s.User.Email))
            .ForMember(dto => dto.AvatarUrl, opt => opt.MapFrom(s => s.User.AvatarUrl));
    }
}