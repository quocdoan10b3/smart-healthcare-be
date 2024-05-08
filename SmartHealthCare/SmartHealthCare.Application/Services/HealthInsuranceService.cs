using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Auth.Requests;
using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Exceptions;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Domain.Resources;
namespace SmartHealthCare.Application.Services;

public class HealthInsuranceService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IHealthInsuranceRepository healthInsuranceRepository,
    IRepositoryBase<Student> studentRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<HealthInsuranceRespone>> GetAllHealthInsurance(GetHealthInsurancesRequest request)
    {
        var result = await healthInsuranceRepository.Search(request.Search)
            .Include(u=> u.Student.User)
            .ProjectTo<HealthInsuranceRespone>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber,request.PageSize);
        return result;
    }

    public async Task<HealthInsurance> GetHealthInsuranceByStudentId(int studentId)
    {
        return await healthInsuranceRepository.GetAsync(_ => _.StudentId == studentId);
    }

    public async Task AddHealthInsuranceStudent(int studentId, AddHealthInsuranceRequest request)
    {
        bool studentExists = await studentRepository.AnyAsync(studentId);
        if (studentExists)
        {
            var healthInsuranceStudent = new HealthInsurance
            {
                InsuranceNumber = request.InsuranceNumber,
                StudentId = studentId,
                ExpDate = request.ExpDate,
                Status = request.Status,
            };
            healthInsuranceRepository.Add(healthInsuranceStudent);
            await unitOfWork.SaveChangesAsync();
        }
        else
        {
            throw new ArgumentException("StudentId doesn't exist");
        }
    }
    
}