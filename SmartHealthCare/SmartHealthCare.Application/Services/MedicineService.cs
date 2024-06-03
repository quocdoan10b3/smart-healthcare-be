using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.ImportMedicine;
using SmartHealthCare.Application.ViewModels.Medicine;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using MedicineResponse = SmartHealthCare.Domain.Repositories.MedicineResponse;

namespace SmartHealthCare.Application.Services;

public class MedicineService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IMedicineRepository medicineRepository,
    IImportMedicineRepository importMedicineRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<MedicineResponse>> GetAllMedicinesAsync(MedicineRequest request)
    {
        var medicinesQuery = await medicineRepository.GetAggregatedMedicinesAsync(request.Search);
        var result = await medicinesQuery
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }
    public async Task<PaginatedList<HistoryImportResponse>> GetAllImportMedicinesAsync(HistoryImportRequest request)
    {
        var result = await importMedicineRepository.Search(request.Search)
            .Include(mi => mi.Medicine)
            .OrderBy(GetOrderByField(request.SortBy), request.IsDescending)
            .ProjectTo<HistoryImportResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }
    public async Task AddMedicineAsync(AddMedicineRequest request)
    {
        var medicine = new Medicine
        {
            Name = request.Name,
            
            Effect = request.Effect,
            
            ImageMedicine = request.ImageMedicine,
        };
        medicineRepository.Add(medicine);
        await unitOfWork.SaveChangesAsync();
    }
    public async Task ImportMedicineAsync(ImportMedicineRequest request)
    {
        bool medicineExists = await medicineRepository.AnyAsync(request.MedicineId);
        if (medicineExists)
        {
            var medicineImport = new MedicineImport
            {
                Quantity = request.Quantity,
                UsedCount = 0,
                MedicineId = request.MedicineId,
                ImportDate = request.ImportDate,
                ExpDate = request.ExpDate
            };
            importMedicineRepository.Add(medicineImport);
            await unitOfWork.SaveChangesAsync();
        }
        else
        {
            throw new ArgumentException("MedicineId doesn't exist");
        }
    }
    private static IOrderByField GetOrderByField(ImportMedicineSortByOption? option)
    {
        return option switch
        {
            ImportMedicineSortByOption.Id
                => new OrderByField<MedicineImport, int>(x => x.Id),
            ImportMedicineSortByOption.ImportDate
                => new OrderByField<MedicineImport, DateTime>(fb => fb.ImportDate),
            _ => throw new ArgumentOutOfRangeException(nameof(option), option, null)
        };
    }
}