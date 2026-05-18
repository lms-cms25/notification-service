using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NotificationService.Application.Abstractions;
using NotificationService.Domain.Entities;
using NotificationService.Infrastructure.Persistance;

namespace NotificationService.Infrastructure.Repositories;
public class NotificationRepository : INotificationRepository
{
    private readonly AppDbContext _context;
    public NotificationRepository(AppDbContext context)
    {
        _context = context;
    }
    // Adds a new notification to the database and saves changes.
    public async Task AddAsync(Notification notification)
    {
        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();
    }
    // Retrieves all notifications for a specific user by their user ID.
    public async Task<IEnumerable<Notification>> GetByUserIdAsync(string userId)
    {
        return await _context.Notifications
            .Where(x => x.UserId == userId)
            .OrderByDescending(x => x.CreatedAt)
            .ToListAsync();
    }
}
