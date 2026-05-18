using System;
using System.Collections.Generic;
using System.Text;
using NotificationService.Domain.Entities;

namespace NotificationService.Application.Abstractions;
public interface INotificationRepository
{
    // Adds a new notification to the repository.
    Task AddAsync(Notification notification);
    // Gets all notifications for a specific user by their user ID.
    Task<IEnumerable<Notification>> GetByUserIdAsync(string userId);
}
