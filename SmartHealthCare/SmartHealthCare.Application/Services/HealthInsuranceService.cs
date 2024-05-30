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
        var query = healthInsuranceRepository.Search(request.Search)
            .Include(hi => hi.Student.User)
            .ProjectTo<HealthInsuranceRespone>(Mapper.ConfigurationProvider);
            // .ToPaginatedListAsync(request.PageNumber,request.PageSize);
            if (request.Filter == HealthInsuranceFilter.True)
            {
                query = query.Where(hi => hi.Status);
            }
            else if(request.Filter == HealthInsuranceFilter.False)
            {
                query = query.Where(hi => !hi.Status);
            }
        Console.Write("aaaaaaaaaaaaaaaaaaaa:",currentUser);
        var result = await query.ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task<HealthInsuranceRespone?> GetHealthInsuranceByStudentId(int studentId)
    {
        var result = await healthInsuranceRepository.GetQuery(_ => _.StudentId == studentId)
            .Include(hi=>hi.Student.User)
            .ProjectTo<HealthInsuranceRespone>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
        return result;
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

    public async Task UpdateStatusHealthInsuranceAsync(int id, UpsertHealthInsuranceRequest request)
    {
        var healthInsurance = await healthInsuranceRepository.GetByIdAsync(id);
        if (healthInsurance == null)
            throw new NotFoundException(nameof(HealthInsurance), id.ToString());
        healthInsurance.Status = request.Status;
        healthInsuranceRepository.Update(healthInsurance);
        await UnitOfWork.SaveChangesAsync();
    }

}