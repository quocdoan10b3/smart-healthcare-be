using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class UsageMedicineRepository : RepositoryBase<History>, IUsageMedicineRepository
{
    public IQueryable<History> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Student.User.FullName) && b.Student.User.FullName.Contains(search)) ||
                            (!string.IsNullOrEmpty(b.UsageDate.ToString()) && b.UsageDate.ToString().Contains(search)));
    
    public UsageMedicineRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}