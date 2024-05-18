using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.ViewModels.Auth.Requests;
using SmartHealthCare.Application.ViewModels.Auth.Responses;
using SmartHealthCare.Domain;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Exceptions;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Domain.Resources;

namespace SmartHealthCare.Application.Services;

public class AuthService(
	TokenService tokenService,
	UserManager<User> userManager,
	IUnitOfWork unitOfWork,
	IMapper mapper,
	IRepositoryBase<Student> studentRepositoryBase,
	ICurrentUser currentUser) : BaseService(unitOfWork, mapper, currentUser)
{
	public async Task<LoginResponse> LoginAsync(LoginRequest request)
	{
		User? user;
		if (request.Identifier.Contains("@"))
			user = await userManager.FindByEmailAsync(request.Identifier);
		else
			user = await userManager.FindByNameAsync(request.Identifier);

		if (user is null)
			throw new AuthException();

		var isPasswordValid = await userManager.CheckPasswordAsync(user, request.Password);
		AuthException.ThrowIfFalse(isPasswordValid);

		var token = tokenService.GenerateToken(user);
		var (refreshToken, expires) = tokenService.GenerateRefreshToken();

		await tokenService.SaveRefreshTokenAsync(refreshToken, user.Id, expires);
		Console.WriteLine("user:", user);
		var userResponse = Mapper.Map<UserResponse>(user);
		var role = userManager.GetRolesAsync(user).Result.First();

		return new LoginResponse(token, refreshToken, userResponse, role);
	}

	public async Task AddStaffAsync(AddStaffRequest request)
	{
		var isEmailTaken = await userManager.FindByEmailAsync(request.Email) != null;
		if (isEmailTaken)
			throw new AlreadyExistsException(nameof(User.Email), request.Email);

		var isUserNameTaken = await userManager.FindByNameAsync(request.UserName) != null;
		if (isUserNameTaken)
			throw new AlreadyExistsException(nameof(User.UserName), request.UserName);

		var user = new User
		{
			UserName = request.UserName,
			Email = request.Email,
			FullName = request.FullName,
			Role = "staff",
			AvatarUrl = request.AvatarUrl,
		};

		await UnitOfWork.BeginTransactionAsync();

		try
		{
			var result = await userManager.CreateAsync(user, request.Password);
			if (result.Succeeded)
				result = await userManager.AddToRoleAsync(user, AppRole.Staff.ToValue());
			if (!result.Succeeded)
				throw new AppException(result.Errors.First().Description);

			await UnitOfWork.CommitAsync();
		}
		catch
		{
			await UnitOfWork.RollbackAsync();
			throw;
		}
	}
	public async Task AddStudentAsync(AddStudentRequest request)
	{
		var isEmailTaken = await userManager.FindByEmailAsync(request.Email) != null;
		if (isEmailTaken)
			throw new AlreadyExistsException(nameof(User.Email), request.Email);

		var isUserNameTaken = await userManager.FindByNameAsync(request.UserName) != null;
		if (isUserNameTaken)
			throw new AlreadyExistsException(nameof(User.UserName), request.UserName);

		var user = new User
		{
			UserName = request.UserName,
			Email = request.Email,
			FullName = request.FullName,
			Role = "student",
			AvatarUrl = request.AvatarUrl
		};
		

		await UnitOfWork.BeginTransactionAsync();

		try
		{
			var result = await userManager.CreateAsync(user, request.Password);
			if (result.Succeeded)
				result = await userManager.AddToRoleAsync(user, AppRole.Student.ToValue());
			
			if (!result.Succeeded)
				throw new AppException(result.Errors.First().Description);
			var student = new Student
			{
				UserId = user.Id,
				StudentCode = request.UserName,
				Class = request.Class,
				Date = request.DateOfBirth,
				Gender = request.Gender,
				Address = request.Address
			};
			studentRepositoryBase.Add(student);
			await UnitOfWork.SaveChangesAsync();
			await UnitOfWork.CommitAsync();
		}
		catch
		{
			await UnitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<RefreshTokenResponse> RefreshTokenAsync(string refreshToken)
	{
		var refreshTokenEntity = await tokenService.ValidateRefreshTokenAsync(refreshToken);

		if (refreshTokenEntity.IsExpired)
			throw new AppException(ErrorMessages.RefreshTokenExpired);

		var user = await userManager.FindByIdAsync(refreshTokenEntity.UserId.ToString())
		           ?? throw new AuthException();

		var (newRefreshToken, expires) = tokenService.GenerateRefreshToken();

		var tokenDto = new RefreshTokenResponse(tokenService.GenerateToken(user), newRefreshToken);

		refreshTokenEntity.Token = newRefreshToken;
		refreshTokenEntity.Expires = expires;

		await UnitOfWork.SaveChangesAsync();

		return tokenDto;
	}
}