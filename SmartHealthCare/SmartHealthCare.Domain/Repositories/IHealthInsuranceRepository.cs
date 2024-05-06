using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Domain.Repositories;

public interface IHealthInsuranceRepository
{
    public IQueryable<HealthInsurance> Search(string? search);
}