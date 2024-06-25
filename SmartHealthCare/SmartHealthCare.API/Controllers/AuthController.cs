using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Auth.Requests;
using SmartHealthCare.Domain.Exceptions;
using LoginRequest = SmartHealthCare.Application.ViewModels.Auth.Requests.LoginRequest;

namespace SmartHealthCare.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
	private readonly AuthService _authService;
	private readonly TokenService _tokenService;

	public AuthController(AuthService authService,
	                      TokenService tokenService)
	{
		_authService = authService;
		_tokenService = tokenService;
	}
	// [Authorize(Roles = "admin")]
	[HttpPost("add-staff")]
	public async Task<IActionResult> AddStaff(AddStaffRequest request)
	{
		await _authService.AddStaffAsync(request);
		return Ok();
	}
	// [Authorize(Roles = "admin")]
	[HttpPost("add-student")]
	public async Task<IActionResult> AddStudent(AddStudentRequest request)
	{
		await _authService.AddStudentAsync(request);
		return Ok();
	}
	[HttpPost("login")]
	public async Task<IActionResult> Login(LoginRequest request)
	{
		var response = await _authService.LoginAsync(request);
		return Ok(response);
	}

	[HttpPost("refresh")]
	public async Task<IActionResult> Refresh([FromQuery] string refreshToken)
	{
		var response = await _authService.RefreshTokenAsync(refreshToken);
		return Ok(response);
	}	
	
	[HttpPost("revoke-token")]
    public async Task<IActionResult> RevokeRefreshToken([FromQuery] string refreshToken)
    {
    	await _tokenService.RevokeRefreshTokenAsync(refreshToken);
    	return Ok();
    }
	[HttpPost("reset-password")]
	public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
	{
		await _authService.ResetPasswordAsync(request);
		return Ok();
	}
}