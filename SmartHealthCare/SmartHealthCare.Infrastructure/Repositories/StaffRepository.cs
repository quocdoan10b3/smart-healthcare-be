using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class StaffRepository : RepositoryBase<Staff>,IStaffRepository
{
    public IQueryable<Staff> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.User.FullName) && b.User.FullName.Contains(search)));
    
    public StaffRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}