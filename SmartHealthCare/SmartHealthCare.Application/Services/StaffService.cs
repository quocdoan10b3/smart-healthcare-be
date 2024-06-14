using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Staff;
using SmartHealthCare.Application.ViewModels.Student;
using SmartHealthCare.Domain.Common;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Exceptions;
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

    public async Task<StaffResponse?> GetStaffByIdAsync(int userId)
    {
        var result = await staffRepository.GetQuery(s => s.User.Id == userId)
            .Include(s => s.User)
            .ProjectTo<StaffResponse>(Mapper.ConfigurationProvider)
            .FirstOrDefaultAsync();
        return result;
    }
    public async Task UpdateInfoStaffAsync(int staffId, UpsertStaffRequest request)
    {
        var staff = await staffRepository.GetByIdAsync(staffId);
        if (staff == null)
            throw new NotFoundException(nameof(Staff), staffId.ToString());
        staff.Address = request.Address;
        staff.Gender = request.Gender;
        staff.Date = request.DateOfBirth;
        staffRepository.Update(staff);
        await UnitOfWork.SaveChangesAsync();
    }
}