using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.HealthRecord;
using SmartHealthCare.Domain.Common;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class HealthRecordService (
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IHealthRecordRepository healthRecordRepository,
    IRepositoryBase<Student> studentRepository) : BaseService (unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<HealthRecordResponse>> GetAllHealthRecords(GetHealthRecordsRequest request)
    {
        var query = healthRecordRepository.Search(request.Search)
            .Include(u => u.Student.User)
            .ProjectTo<HealthRecordResponse>(Mapper.ConfigurationProvider);
            // .ToPaginatedListAsync(request.PageNumber,request.PageSize);
            var scholasticYear = request.Filter.GetEnumMemberValue().ToString();
            if (scholasticYear != "None")
                query = query.Where(hr => hr.Scholastic == scholasticYear);
        var result = await query.ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }
    public async Task<List<HealthRecordResponse>> GetHealthRecordByStudentId(int studentId)
    {
        // var result = await healthRecordRepository.GetQuery(_ => _.StudentId == studentId)
        //     .Include(hi=>hi.Student.User)
        //     .ProjectTo<HealthRecordResponse>(Mapper.ConfigurationProvider)
        //     .FirstOrDefaultAsync();
        var result = await healthRecordRepository.GetQuery(_ => _.StudentId == studentId)
            .Include(hi => hi.Student.User)
            .ProjectTo<HealthRecordResponse>(Mapper.ConfigurationProvider)
            .ToListAsync();
        return result;
    }
    
    public async Task AddHealthRecordStudent(int studentId, AddHealthRecordRequest request)
    {
        bool studentExists = await studentRepository.AnyAsync(studentId);
        if (studentExists)
        {
            var healthRecordStudent = new HealthRecord
            {
                StudentId = studentId,
                ExamDate = request.ExamDate,
                Height = request.Height,
                Weight = request.Weight,
                Vision = request.Vision,
                Hearing = request.Hearing,
                DentalHealth = request.DentalHealth,
                Allergies = request.Allergies,
                Notes = request.Notes,
                Scholastic = $"{request.Scholastic}-{int.Parse(request.Scholastic) + 1}"
            };
            healthRecordRepository.Add(healthRecordStudent);
            await unitOfWork.SaveChangesAsync();
        }
        else
        {
            throw new ArgumentException("StudentId doesn't exist");
        }
    }
    public async Task<bool> CheckStudentIsExamAsync(int studentId,int currentYear)
    {
        var healthRecords =  await GetHealthRecordByStudentId(studentId);
        foreach (var healthRecord in healthRecords)
        {
            string scholastic = healthRecord.Scholastic;
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
        var scholasticYears = await healthRecordRepository.GetQuery()
            .Select(hr => hr.Scholastic)
            .Distinct()
            .ToListAsync();
        return scholasticYears;
    }
}