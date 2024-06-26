using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Student;
using SmartHealthCare.Domain.Common;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Exceptions;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class StudentService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IStudentRepository studentRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<StudentResponse>> GetAllStudentsAsync(GetStudentsRequest request)
    {
        var query = studentRepository.Search(request.Search)
            .Include(s => s.User)
            .ProjectTo<StudentResponse>(Mapper.ConfigurationProvider);
            var grade = request.Filter.GetEnumMemberValue();
                if (grade != "None")
                    query = query.Where(s=>s.Class.StartsWith(grade));
        var result = await query.ToPaginatedListAsync(request.PageNumber, request.PageSize);                
        return result;
    }
    public async Task<StudentResponse?> GetStudentByUserId(int userId)
    {
        var result = await studentRepository.GetQuery(_ => _.UserId == userId)
            .Include(s=> s.User)
            .ProjectTo<StudentResponse>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
        return result;
    }
    public async Task UpdateInfoStudentAsync(int studentId, UpsertStudentRequest request)
    {
        var student = await studentRepository.GetByIdAsync(studentId);
        if (student == null)
            throw new NotFoundException(nameof(Student), studentId.ToString());
        student.Address = request.Address;
        student.Gender = request.Gender;
        student.Class = request.Class;
        student.Date = request.DateOfBirth;
        studentRepository.Update(student);
        await UnitOfWork.SaveChangesAsync();
    }
}