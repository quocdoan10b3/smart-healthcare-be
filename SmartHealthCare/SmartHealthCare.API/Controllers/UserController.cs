using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.User;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService=userService;
    }
    [HttpGet()]
    public async Task<IActionResult> GetAllUsers([FromQuery] GetUsersRequest pqp)
    {
        var response = await _userService.GetAllUserAsync(pqp);
        return Ok(response);
    }
}