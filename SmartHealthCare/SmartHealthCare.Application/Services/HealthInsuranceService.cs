using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Auth.Requests;
using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Application.ViewModels.Student;
using SmartHealthCare.Domain;
using SmartHealthCare.Domain.Common;
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
            var scholasticYear = request.Filter.GetEnumMemberValue().ToString();
            Console.Write("a1a1:{0}",scholasticYear);
            if (scholasticYear != "None")
            query = query.Where(hi => hi.Scholastic == scholasticYear);
        Console.Write("aaaaaaaaaaaaaaaaaaaa:",currentUser);
        var result = await query.ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task<List<HealthInsuranceRespone>> GetHealthInsuranceByStudentId(int studentId)
    {
        // var result = await healthInsuranceRepository.GetQuery(_ => _.StudentId == studentId)
        //     .Include(hi=>hi.Student.User)
        //     .ProjectTo<HealthInsuranceRespone>(Mapper.ConfigurationProvider)
        //     .FirstOrDefaultAsync();
        var result = await healthInsuranceRepository.GetQuery(_ => _.StudentId == studentId)
            .Include(hi=>hi.Student.User)
            .ProjectTo<HealthInsuranceRespone>(Mapper.ConfigurationProvider)
            .ToListAsync();
        return result;
    }
    public async Task<List<HealthInsuranceRespone>> GetHealthInsuranceByUserIdAsync(int userId)
    {
        var student = await studentRepository.GetQuery(_ => _.UserId == userId)
            .Include(s=> s.User)
            .ProjectTo<StudentResponse>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();

        var result = await healthInsuranceRepository.GetQuery(_ => _.StudentId == student.Id)
            .Include(hi=>hi.Student.User)
            .ProjectTo<HealthInsuranceRespone>(Mapper.ConfigurationProvider)
            .ToListAsync();
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
                Scholastic = $"{request.Scholastic}-{int.Parse(request.Scholastic) + 1}",
                StaffId = request.StaffId
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
    public async Task<bool> CheckStudentHasHealthInsuranceAsync(int studentId,int currentYear)
    {
        var healthInsurances =  await GetHealthInsuranceByStudentId(studentId);
        foreach (var healthInsurance in healthInsurances)
        {
            string scholastic = healthInsurance.Scholastic;
            string[] years = scholastic.Split('-');
            if (years.Length == 2 && int.TryParse(years[0], out int startYear))
            {
                if (startYear == currentYear)
                {
                    return true;
                }
            }
        }
        return false;
    }
    public async Task<List<string>> GetAllScholasticYearsAsync()
    {
        var scholasticYears = await healthInsuranceRepository.GetQuery()
            .Select(hr => hr.Scholastic)
            .Distinct()
            .ToListAsync();
        return scholasticYears;
    }
}