using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Domain.Repositories;

public interface IStudentRepository : IRepositoryBase<Student>
{
    public IQueryable<Student> Search(string? search);
}