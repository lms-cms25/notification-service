using Microsoft.AspNetCore.Mvc;
using NotificationService.Application.Abstractions;
using NotificationService.Application.Dtos;
using NotificationService.Domain.Entities;
namespace NotificationService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificationsController : ControllerBase
{
    private readonly INotificationRepository _repository;
    public NotificationsController(INotificationRepository repository)
    {
        _repository = repository;
    }
    [HttpPost]
    public async Task<IActionResult> Create(NotificationDto dto)
    {
        var notification = new Notification
        {
            UserId = dto.UserId,
            Message = dto.Message,
            CreatedAt = DateTime.UtcNow,
        };
        await _repository.AddAsync(notification);
        return Ok(notification);
    }
    [HttpGet]
    public async Task<IActionResult> Get(string userId)
    {
        var notifications = await _repository.GetByUserIdAsync(userId);
        return Ok(notifications);
    }
}
