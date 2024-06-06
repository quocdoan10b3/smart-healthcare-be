using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IStaffRepository : IRepositoryBase<Staff>
{
    public IQueryable<Staff> Search(string? search);
}