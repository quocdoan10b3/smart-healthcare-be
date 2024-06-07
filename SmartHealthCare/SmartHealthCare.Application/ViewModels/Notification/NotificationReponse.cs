using AutoMapper;
using SmartHealthCare.Application.ViewModels.FeedBack;

namespace SmartHealthCare.Application.ViewModels.Notification;

public class NotificationReponse
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public string? Content { get; set; } = String.Empty;
    public string? Image { get; set; } = String.Empty;
    public DateTime DateCreatAt { get; set; }
    public string? ByUserName { get; set; } = String.Empty;
}
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Domain.Entities.Notification, NotificationReponse>();
    }
}