using System;
using System.Collections.Generic;
using System.Text;
using NotificationService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace NotificationService.Infrastructure.Persistance;
public class AppDbContext : DbContext
{
    // Setting up DB context to manage notifications in the database.
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    // Table for notifications in the database.
    public DbSet<Notification> Notifications => Set<Notification>();
}
