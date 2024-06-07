using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.Auth.Responses;
using SmartHealthCare.Application.ViewModels.User;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class UserService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    UserManager<User> userManager,
    IRepositoryBase<Staff> repositoryBase) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<User>> GetAllUserAsync(GetUsersRequest request)
    {
        return await userManager.Users.ToPaginatedListAsync(request.PageNumber, request.PageSize);
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        return await userManager.Users.Where(u=> u.Id == userId).FirstOrDefaultAsync();
    }

    public async Task<Staff> GetStaffByIdAsync(int userId)
    {
        return await repositoryBase.GetQuery(s => s.UserId == userId).FirstOrDefaultAsync();
    }

    public async Task UpdateAvatarAsync(int userId, UpsertUserRequest request)
    {
        var user = userManager.Users.Where(u => u.Id == userId).FirstOrDefaultAsync().Result;
        if( user != null ) user.AvatarUrl = request.AvatarUrl;
        await UnitOfWork.SaveChangesAsync();
    }

    public async Task DeleteUserAsyc(int userId)
    {
        var user = await userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user != null)
        {
            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                await unitOfWork.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Failed to delete user");
            }
        }
    }
}