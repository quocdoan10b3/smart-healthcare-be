using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class HealthRecordRepository: RepositoryBase<HealthRecord>,IHealthRecordRepository
{
    public IQueryable<HealthRecord> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Student.User.FullName) && b.Student.User.FullName.Contains(search)));

    public HealthRecordRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}