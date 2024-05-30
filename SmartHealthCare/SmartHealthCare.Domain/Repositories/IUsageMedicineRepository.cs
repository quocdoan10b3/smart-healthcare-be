using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IUsageMedicineRepository : IRepositoryBase<History>
{
    public IQueryable<History> Search(string? search);
}