using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class MedicineRepository : RepositoryBase<Medicine>, IMedicineRepository
{
    public IQueryable<Medicine> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Name) && b.Name.Contains(search)));
    
    public MedicineRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}