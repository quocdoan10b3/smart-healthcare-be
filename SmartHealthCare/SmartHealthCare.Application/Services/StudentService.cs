using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Student;
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
        var result = await studentRepository.Search(request.Search)
            .Include(s => s.User)
            .ProjectTo<StudentResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }
}