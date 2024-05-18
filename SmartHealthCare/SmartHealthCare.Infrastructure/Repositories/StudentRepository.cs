using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Repositories.Base;

namespace SmartHealthCare.Infrastructure.Repositories;

public class StudentRepository: RepositoryBase<Student>,IStudentRepository
{
    public IQueryable<Student> Search(string? search)
        => string.IsNullOrWhiteSpace(search) 
            ? GetQuery() 
            : GetQuery(b => (!string.IsNullOrEmpty(b.Address) && b.Address.Contains(search)));
    
    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}