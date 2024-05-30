using AutoMapper;
using SmartHealthCare.Application.ViewModels.Medicine;

namespace SmartHealthCare.Application.ViewModels.FeedBack;

public class FeedBackResponse
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public float Rating { get; set; }
    public string Comments { get; set; } = String.Empty;
    public string CommentDate { get; set; } = String.Empty;
    public string Response { get; set; } = String.Empty;
    public string ResponseDate { get; set; } = String.Empty;
    public string StudentName { get; set; } = String.Empty;
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.FeedBack, FeedBackResponse>()
            .ForMember(dto => dto.StudentName, opt => opt.MapFrom(h => h.Student.User.FullName));
    }
}