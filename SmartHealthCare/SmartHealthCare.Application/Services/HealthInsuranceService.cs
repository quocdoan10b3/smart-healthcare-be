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
            if (request.FilterStatus == HealthInsuranceFilterStatus.True)
            {
                query = query.Where(hi => hi.Status);
            }
            else if(request.FilterStatus == HealthInsuranceFilterStatus.False)
            {
                query = query.Where(hi => !hi.Status);
            }
            if (request.Filter == HealthInsuranceFilter.N2020_2021)
            {
                query = query.Where(hi => hi.Scholastic == "2020-2021");
            }
            else if(request.Filter == HealthInsuranceFilter.N2021_2022)
            {
                query = query.Where(hi => hi.Scholastic == "2021-2022");
            }
            else if(request.Filter == HealthInsuranceFilter.N2022_2023)
            {
                query = query.Where(hi => hi.Scholastic == "2022-2023");
            }
            else if(request.Filter == HealthInsuranceFilter.N2023_2024)
            {
                query = query.Where(hi => hi.Scholastic == "2023-2024");
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