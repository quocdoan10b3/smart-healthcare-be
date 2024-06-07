using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Notification;
using SmartHealthCare.Domain;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/news")]
public class NotificationController : ControllerBase
{
    private readonly NotificationService _notificationService;

    public NotificationController(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllNews([FromQuery] GetNotificationRequest pqp)
    {
        var response = await _notificationService.GetAllNewsAsync(pqp);
        return Ok(response);
    }
    [Authorize(Roles = AppRole.Admin + "," + AppRole.Staff)]
    [HttpPost]
    public async Task<IActionResult> CreateNews(AddNotificationRequest request)
    {
        await _notificationService.CreatNewsAsync(request);
        return Ok();
    }
    [Authorize(Roles = AppRole.Admin)]
    [HttpDelete("{newsId:int}")]
    public async Task<IActionResult> DeleteNews(int newsId)
    {
        await _notificationService.DeleteNewsAsync(newsId);
        return Ok();
    }
}