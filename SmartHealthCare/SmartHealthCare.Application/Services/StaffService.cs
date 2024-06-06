using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Staff;
using SmartHealthCare.Application.ViewModels.Student;
using SmartHealthCare.Domain.Common;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class StaffService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IStaffRepository staffRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<StaffResponse>> GetAllStaffsAsync(GetStaffRequest request)
    {
        var result =await staffRepository.Search(request.Search)
            .Include(s => s.User)
            .ProjectTo<StaffResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);                
        return result;
    }
}