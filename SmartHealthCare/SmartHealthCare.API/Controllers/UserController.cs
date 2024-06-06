using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.User;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/user")]
[Authorize]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService=userService;
    }
    // [Authorize(Roles = "admin")]
    [HttpGet()]
    public async Task<IActionResult> GetAllUsers([FromQuery] GetUsersRequest pqp)
    {
        var response = await _userService.GetAllUserAsync(pqp);
        return Ok(response);
    }
    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetUserByIdAsync(int userId)
    {
        var response = await _userService.GetUserByIdAsync(userId);
        return Ok(response);
    }
    [HttpPut("{userId:int}")]
    public async Task<IActionResult> UpdateAvatar(int userId,[FromBody] UpsertUserRequest request)
    {
        await _userService.UpdateAvatarAsync(userId,request);
        return Ok();
    }
    [HttpGet("staff/{userId:int}")]
    public async Task<IActionResult> GetStaff(int userId)
    {
        var response = await _userService.GetStaffByIdAsync(userId);
        return Ok(response);
    }
}