using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IHealthRecordRepository : IRepositoryBase<HealthRecord>
{
    public IQueryable<HealthRecord> Search(string? search);
}