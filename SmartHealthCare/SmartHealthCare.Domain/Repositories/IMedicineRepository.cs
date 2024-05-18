using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IMedicineRepository : IRepositoryBase<Medicine>
{
    public IQueryable<Medicine> Search(string? search);
}