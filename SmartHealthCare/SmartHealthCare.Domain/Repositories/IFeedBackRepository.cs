using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IFeedBackRepository : IRepositoryBase<FeedBack>
{
    public IQueryable<FeedBack> Search(string? search);
}