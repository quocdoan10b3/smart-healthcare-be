using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IHealthInsuranceRepository : IRepositoryBase<HealthInsurance>
{
    public IQueryable<HealthInsurance> Search(string? search);
}