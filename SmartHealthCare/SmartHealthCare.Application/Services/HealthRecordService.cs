using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.HealthRecord;
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
        if (request.Filter == HealthRecordFilter.N2020_2021)
        {
            query = query.Where(hi => hi.Scholastic == "2020-2021");
        }
        else if(request.Filter == HealthRecordFilter.N2021_2022)
        {
            query = query.Where(hi => hi.Scholastic == "2021-2022");
        }
        else if(request.Filter == HealthRecordFilter.N2022_2023)
        {
            query = query.Where(hi => hi.Scholastic == "2022-2023");
        }
        else if(request.Filter == HealthRecordFilter.N2023_2024)
        {
            query = query.Where(hi => hi.Scholastic == "2023-2024");
        }

        var result = await query.ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }
    public async Task<HealthRecordResponse?> GetHealthRecordByStudentId(int studentId)
    {
        var result = await healthRecordRepository.GetQuery(_ => _.StudentId == studentId)
            .Include(hi=>hi.Student.User)
            .ProjectTo<HealthRecordResponse>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
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
                Notes = request.Notes
            };
            healthRecordRepository.Add(healthRecordStudent);
            await unitOfWork.SaveChangesAsync();
        }
        else
        {
            throw new ArgumentException("StudentId doesn't exist");
        }
    }
    public async Task<bool> CheckStudentIsExamAsync(int studentId)
    {
        var healthRecord =  await GetHealthRecordByStudentId(studentId);
        bool isExam = healthRecord != null;
        return isExam;
    }
}