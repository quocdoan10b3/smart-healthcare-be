using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using LoginRequest = SmartHealthCare.Application.ViewModels.Auth.Requests.LoginRequest;
using RegisterRequest = SmartHealthCare.Application.ViewModels.Auth.Requests.RegisterRequest;

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

	[HttpPost("register")]
	public async Task<IActionResult> Register(RegisterRequest request)
	{
		await _authService.RegisterAsync(request);
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
    
}