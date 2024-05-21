using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class HealthInsuranceRepository: RepositoryBase<HealthInsurance>,IHealthInsuranceRepository
{
    public IQueryable<HealthInsurance> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
        ? GetQuery() 
        : GetQuery(b => (!string.IsNullOrEmpty(b.Student.User.FullName) && b.Student.User.FullName.Contains(search)));
    
    public HealthInsuranceRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}