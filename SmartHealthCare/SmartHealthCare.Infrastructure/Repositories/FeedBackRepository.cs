using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class FeedBackRepository: RepositoryBase<FeedBack>,IFeedBackRepository
{
    public IQueryable<FeedBack> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Id.ToString()) && b.Id.ToString().Contains(search)));
    
    public FeedBackRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}