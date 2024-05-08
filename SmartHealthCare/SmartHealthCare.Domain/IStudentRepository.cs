using SmartHealthCare.Domain.Entities;

namespace SmartHealthCare.Domain;

public interface IStudentRepository
{
    Task AddStudentAsync(Student student);
}