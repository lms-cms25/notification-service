using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationService.Application.Dtos;
public class NotificationDto
{
    public string UserId { get; set; } = null!;
    public string Message { get; set; } = null!;
}
