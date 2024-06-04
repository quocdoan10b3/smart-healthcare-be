using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Medicine;
using SmartHealthCare.Application.ViewModels.UsageMedicine;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class UsageMedicineService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IUsageMedicineRepository usageMedicineRepository,
    IRepositoryBase<Student> studentRepository,
    IRepositoryBase<Medicine> medicineRepositoryBase,
    IRepositoryBase<Prescription> prescriptionRepositoryBase,
    IRepositoryBase<MedicineImport> medicineImportRepositoryBase) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<HistoryResponse>> GetAllUsageMedicinesAsync(HistoryRequest request)
    {
        var result = await usageMedicineRepository.Search(request.Search)
            .Include(h=> h.Student)
            .Include(h=> h.Prescriptions)
            .OrderBy(GetOrderByField(request.SortBy), request.IsDescending)
            .ProjectTo<HistoryResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task<PaginatedList<HistoryResponse>> GetUsageMedicinesByStudentIdAsync(int studentId,HistoryRequest request)
    {
        var result = await usageMedicineRepository.GetQuery(_ => _.StudentId == studentId)
            .Include(h=>h.Prescriptions)
            .ProjectTo<HistoryResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber,request.PageSize);
        return result;
    }

    public async Task UsageMedicineByStudentIdAsync(int studentId, AddUsageMedicineRequest request)
    {
        bool studentExists = await studentRepository.AnyAsync(studentId);
        if (studentExists)
        {
            await UnitOfWork.BeginTransactionAsync();
            try
            {
                foreach (var prescriptionRequest in request.AddPrescriptionRequests)
                {
                    var subMedicineRequest = new SubMedicineRequest
                    (
                        prescriptionRequest.MedicineId,
                        prescriptionRequest.Quantity,
                        request.UsageDate
                    );
                    await SubMedicineAsync(subMedicineRequest);
                }
                var historyUsage = new History
                {
                    StudentId = studentId,
                    UsageDate = request.UsageDate,
                    Reason = request.Reason
                };
                usageMedicineRepository.Add(historyUsage);
                await UnitOfWork.SaveChangesAsync(); 
                var historyId = historyUsage.Id;
                
                foreach (var prescriptionRequest in request.AddPrescriptionRequests)
                {
                    var prescription = new Prescription
                    {
                        HistoryId = historyId,
                        MedicineId = prescriptionRequest.MedicineId,
                        Quantity = prescriptionRequest.Quantity
                    };
                    prescriptionRepositoryBase.Add(prescription);
                }
                await UnitOfWork.SaveChangesAsync();
                await UnitOfWork.CommitAsync();
            }
            catch
            {
                await UnitOfWork.RollbackAsync();
                throw;
            }
        }
        else
        {
            throw new ArgumentException("StudentId doesn't exist");
        }
    }
    public async Task SubMedicineAsync(SubMedicineRequest request)
    {
        var medicines = await medicineImportRepositoryBase.GetQuery()
            .Where(m => m.MedicineId == request.MedicineId && m.ExpDate.Date >= request.UsageDate.Date &&
                        m.Quantity - m.UsedCount > 0)
            .OrderBy(m => m.ExpDate)
            .ToListAsync();
            
        int remainQuantity = request.Quantity;
        {
            foreach (var medicine in medicines)
            {
                if (medicine.Quantity - medicine.UsedCount >= remainQuantity)
                {
                    medicine.UsedCount += remainQuantity;
                    remainQuantity = 0;
                    break;
                }
                else
                {
                    remainQuantity = remainQuantity - (medicine.Quantity - medicine.UsedCount);
                    medicine.UsedCount = medicine.Quantity;
                }
            }
            if (remainQuantity > 0)
            {
                throw new InvalidOperationException("Not enough medicine in stock.");
            }
            await UnitOfWork.SaveChangesAsync();
        }
        
    }
    private static IOrderByField GetOrderByField(HistoriesSortByOption? option)
    {
        return option switch
        {
            HistoriesSortByOption.Id
                => new OrderByField<History, int>(x => x.Id),
            HistoriesSortByOption.StudentName
                => new OrderByField<History, string>(fb => fb.Student.User.FullName),
            _ => throw new ArgumentOutOfRangeException(nameof(option), option, null)
        };
    }
}