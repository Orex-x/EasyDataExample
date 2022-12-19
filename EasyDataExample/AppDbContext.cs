using EasyDataExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyDataExample;

public class AppDbContext : DbContext
{
    public DbSet<BuildingService> BuildingServices { get; set; }
    public DbSet<BuildingServiceContract> BuildingServiceContracts { get; set; }
    public DbSet<BuildingServiceMaterial> BuildingServiceMaterials { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<Stage> Stages { get; set; }
    public DbSet<TypeClimaticCondition> TypeClimaticConditions { get; set; }
    public DbSet<TypeGround> TypeGrounds { get; set; }
    public DbSet<TypeRelief> TypeReliefs { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}