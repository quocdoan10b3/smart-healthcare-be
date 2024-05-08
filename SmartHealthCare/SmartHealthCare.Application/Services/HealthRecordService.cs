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
        var result = await healthRecordRepository.Search(request.Search)
            .Include(u=> u.Student.User)
            .ProjectTo<HealthRecordResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber,request.PageSize);
        return result;
    }
    public async Task<HealthRecord> GetHealthRecordByStudentId(int studentId)
    {
        return await healthRecordRepository.GetAsync(_ => _.StudentId == studentId);
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
}