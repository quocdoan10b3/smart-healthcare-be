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
    UserManager<User> userManager) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<User>> GetAllUserAsync(GetUsersRequest request)
    {
        return await userManager.Users.ToPaginatedListAsync(request.PageNumber, request.PageSize);
    }
}