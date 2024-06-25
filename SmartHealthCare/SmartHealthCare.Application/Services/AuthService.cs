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
	IEmailSender emailSender,
	IRepositoryBase<Student> studentRepositoryBase,
	IRepositoryBase<Staff> staffRepositoryBase,
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
		var role = userManager.GetRolesAsync(user).Result.First();
		var token = tokenService.GenerateToken(user,role);
		var (refreshToken, expires) = tokenService.GenerateRefreshToken();

		await tokenService.SaveRefreshTokenAsync(refreshToken, user.Id, expires);
		Console.WriteLine("user:", user);
		var userResponse = Mapper.Map<UserResponse>(user);
		

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
				result = await userManager.AddToRoleAsync(user, AppRole.Staff);
			if (!result.Succeeded)
				throw new AppException(result.Errors.First().Description);
			var staff = new Staff
			{
				UserId = user.Id,
				Date = request.DateOfBirth,
				Gender = request.Gender,
				Address = request.Address
			};
			staffRepositoryBase.Add(staff);
			await UnitOfWork.SaveChangesAsync();
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
				result = await userManager.AddToRoleAsync(user, AppRole.Student);
			
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
		var role = userManager.GetRolesAsync(user).Result.First();
		var tokenDto = new RefreshTokenResponse(tokenService.GenerateToken(user,role), newRefreshToken);

		refreshTokenEntity.Token = newRefreshToken;
		refreshTokenEntity.Expires = expires;

		await UnitOfWork.SaveChangesAsync();

		return tokenDto;
	}

	public async Task ResetPasswordAsync(ResetPasswordRequest request)
	{
		var user = await userManager.FindByNameAsync(request.UserName);
		if (user == null) throw new NotFoundException(nameof(User), request.UserName);
		if (user.Email != request.Email || user.FullName != request.FullName)
			throw new AuthException();
		var newPassword = RandomPassword(8);
		var resetToken = await userManager.GeneratePasswordResetTokenAsync(user);
		var result = await userManager.ResetPasswordAsync(user, resetToken, newPassword);
		if (!result.Succeeded)
		{
			throw new Exception();
		}
		var subject = "Website quản lý y tế học đường";
		var content = $"<p>Mật khẩu tài khoản của bạn vừa được reset. Dưới đây là thông tin chi tiết mật khẩu của bạn:</p>" +
		              $"<p><strong>Họ và tên:</strong> {user.FullName}</p>" +
		              $"<p><strong>Username:</strong> {user.UserName}</p>" +
		              $"<p><strong>Password:</strong> {newPassword}</p>" +
		              $"<p>Hãy đăng nhập và đổi mật khẩu sớm nhất có thể.</p>";
		var message = new Message(new List<string> { user.Email! }, subject, content);
		await emailSender.SendEmailAsync(message);
	}
	private string RandomPassword(int length)
	{
		const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string lowercase = "abcdefghijklmnopqrstuvwxyz";
		const string digits = "0123456789";
		const string specialChars = "!@#$%^&*()_+[]{}|;:,.<>?";
		const string allChars = uppercase + lowercase + digits + specialChars;
		Random random = new Random();
    
		string password = new string(Enumerable.Repeat(allChars, length)
			.Select(s => s[random.Next(s.Length)]).ToArray());
		if (!password.Any(char.IsUpper))
			password = ReplaceChar(password, uppercase[random.Next(uppercase.Length)], random.Next(password.Length));
		if (!password.Any(char.IsLower))
			password = ReplaceChar(password, lowercase[random.Next(lowercase.Length)], random.Next(password.Length));
		if (!password.Any(char.IsDigit))
			password = ReplaceChar(password, digits[random.Next(digits.Length)], random.Next(password.Length));
		if (!password.Any(c => specialChars.Contains(c)))
			password = ReplaceChar(password, specialChars[random.Next(specialChars.Length)], random.Next(password.Length));
		
		return password;
	}

	private string ReplaceChar(string str, char newChar, int index)
	{
		var chars = str.ToCharArray();
		chars[index] = newChar;
		return new string(chars);
	}

}