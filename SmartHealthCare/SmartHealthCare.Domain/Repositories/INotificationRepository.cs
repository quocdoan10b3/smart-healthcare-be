using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface INotificationRepository : IRepositoryBase<Notification>
{
    public IQueryable<Notification> Search(string? search);
}