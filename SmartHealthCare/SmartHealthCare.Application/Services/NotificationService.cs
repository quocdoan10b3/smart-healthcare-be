using AutoMapper;
using AutoMapper.QueryableExtensions;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.FeedBack;
using SmartHealthCare.Application.ViewModels.Notification;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class NotificationService (
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    INotificationRepository notificationRepository) : BaseService(unitOfWork,mapper,currentUser)
{
    public async Task<PaginatedList<NotificationReponse>> GetAllNewsAsync(GetNotificationRequest request)
    {
        var result = await notificationRepository.Search(request.Search)
            .OrderBy(GetOrderByField(request.SortBy), request.IsDescending)
            .ProjectTo<NotificationReponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task CreatNewsAsync(AddNotificationRequest request)
    {
        var news = new Notification
        {
            Title = request.Title,
            Content = request.Content,
            DateCreatAt = request.DateCreatAt,
            Image = request.Image,
            StaffId = request.StaffId
        };
        notificationRepository.Add(news);
        await unitOfWork.SaveChangesAsync();
    }
    private static IOrderByField GetOrderByField(NotificationSortByOption? option)
    {
        return option switch
        {
            NotificationSortByOption.Id
                => new OrderByField<Notification, int>(x => x.Id),
            _ => throw new ArgumentOutOfRangeException(nameof(option), option, null)
        };
    }
}