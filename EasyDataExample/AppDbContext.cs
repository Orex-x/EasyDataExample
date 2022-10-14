using EasyDataExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyDataExample;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}