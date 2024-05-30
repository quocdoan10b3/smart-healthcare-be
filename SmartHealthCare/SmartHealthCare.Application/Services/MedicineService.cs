using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Medicine;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class MedicineService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IMedicineRepository medicineRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<MedicineResponse>> GetAllMedicinesAsync(MedicineRequest request)
    {
        var result = await medicineRepository.Search(request.Search)
            .ProjectTo<MedicineResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task AddMedicineAsync(AddMedicineRequest request)
    {
        var isMedicine = medicineRepository.GetQuery()
            .Where(m => m.Name == request.Name)
            .FirstOrDefaultAsync()
            .Result;
        
        
        await UnitOfWork.BeginTransactionAsync();
        try
        {
            if (isMedicine == null)
            {
                var medicine = new Medicine
                {
                    Name = request.Name,
                    Quantity = request.Quantity,
                    Effect = request.Effect,
                    // ImportDate = request.ImportDate,
                    // ExpDate = request.ExpDate
                };
                medicineRepository.Add(medicine);
            }
            else
            {
                isMedicine.Quantity += request.Quantity;
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

    public async Task SubMedicineAsync(SubMedicineRequest request)
    {
        var medicine = medicineRepository.GetQuery()
            .Where(m => m.Id == request.Id)
            .FirstOrDefaultAsync()
            .Result;
        
        await UnitOfWork.BeginTransactionAsync();
        try
        {
            if (medicine != null && medicine.Quantity > 0 && medicine.Quantity > request.Quantity)
            {
                medicine.Quantity -= request.Quantity;
            }
            else
            {
                throw new InvalidOperationException("Invalid medicine data or insufficient quantity.");
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
}