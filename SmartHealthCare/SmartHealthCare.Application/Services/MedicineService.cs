using AutoMapper;
using AutoMapper.QueryableExtensions;
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
    IMedicineRepository medicineRepository,
    IRepositoryBase<Medicine> medicinerepositoryBase) : BaseService(unitOfWork, mapper, currentUser)
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
        var medicine = new Medicine
        {
            Name = request.Name,
            Quantity = request.Quantity,
            Effect = request.Effect,
            ImportDate = request.ImportDate,
            ExpDate = request.ExpDate
        };
        await UnitOfWork.BeginTransactionAsync();
        try
        {
            medicineRepository.Add(medicine);
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