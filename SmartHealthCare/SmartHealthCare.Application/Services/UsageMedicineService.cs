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
    IUsageMedicineRepository usageMedicineRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<HistoryResponse>> GetAllUsageMedicinesAsync(HistoryRequest request)
    {
        var result = await usageMedicineRepository.Search(request.Search)
            .Include(h=> h.Student)
            .Include(h=> h.Prescriptions)
            .ProjectTo<HistoryResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task<HistoryResponse?> GetUsageMedicinesByStudentIdAsync(int studentId)
    {
        var result = await usageMedicineRepository.GetQuery(_ => _.StudentId == studentId)
            .Include(h=>h.Prescriptions)
            .ProjectTo<HistoryResponse>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
        return result;
    }
}