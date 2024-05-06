using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Exceptions;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Domain.Resources;
namespace SmartHealthCare.Application.Services;

public class HealthInsuranceService(IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IHealthInsuranceRepository healthInsurance,
    IRepositoryBase<HealthInsurance> healthInsuranceRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<HealthInsurance>> GetAllHealthInsurance(GetHealthInsurancesRequest request)
    {
        var result = await healthInsurance.Search(request.Search)
            .ProjectTo<HealthInsurance>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber,request.PageSize);
        return result;
    }

    public async Task<HealthInsurance?> GetHealthInsuranceByStudentId(int studentId)
    {
        return await healthInsuranceRepository.GetAsync(_ => _.StudentId == studentId);
    }
    
}