using System;
using System.Collections.Generic;
using System.Text;
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
    public async Task AddAsync(Notification notification)
    {
        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();
    }

    public Task<IEnumerable<Notification>> GetByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
