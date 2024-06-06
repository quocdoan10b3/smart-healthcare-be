using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class NotificationRepository : RepositoryBase<Notification>, INotificationRepository
{
    public IQueryable<Notification> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Title.ToString()) && b.Title.ToString().Contains(search)));
    
    public NotificationRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}