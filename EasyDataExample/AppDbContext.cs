using EasyDataExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyDataExample;

public class AppDbContext : DbContext
{
    public DbSet<BuildingService> BuildingServices { get; set; }
    public DbSet<BuildingServiceContract> BuildingServiceContracts { get; set; }
   // public DbSet<BuildPhase> BuildPhases { get; set; }
  //  public DbSet<BuildPhaseContract> BuildPhaseContracts { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Estimate> Estimates { get; set; }
    public DbSet<Material> Materials { get; set; }
   // public DbSet<Order> Orders { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}