using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Application.ViewModels.Auth.Requests;
using SmartHealthCare.Application.ViewModels.FeedBack;
using SmartHealthCare.Application.ViewModels.HealthInsurance;
using SmartHealthCare.Domain;

namespace SmartHealthCare.Controllers;
[ApiController]
[Route("api/feed-back")]
public class FeedBackController : ControllerBase
{
    private readonly FeedBackService _feedBackService;

    public FeedBackController(FeedBackService feedBackService)
    {
        _feedBackService = feedBackService;
    }
    [Authorize]
    [HttpGet()]
    public async Task<IActionResult> GetAllFeedBacks([FromQuery] GetFeedBackRequest pqp)
    {
        var response = await _feedBackService.GetAllFeedBacksAsync(pqp);
        return Ok(response);
    }
    
    [HttpPost("{studentId:int}")]
    public async Task<IActionResult> CreateFeedBackByStudent(int studentId, AddFeedBackRequest request)
    {
        await _feedBackService.CreateFeedBackByStudentAsync(studentId,request);
        return Ok();
    }
    [Authorize(Roles = AppRole.Admin)]
    [HttpPut("{feedBackId}")]
    public async Task<IActionResult> AdminResponseFeedBack(int feedBackId,
        [FromBody] UpsertFeedBackRequest request)
    {
        await _feedBackService.AdminResponseFeedBackAsync(feedBackId,request);
        return Ok();
    }
}