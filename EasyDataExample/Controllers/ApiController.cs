using EasyDataExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyDataExample.Controllers;


[Route("api/easydata/models/__default/sources")]
public class ApiController : Controller
{
    private AppDbContext _db;
    public ApiController(AppDbContext db)
    {
        _db = db;
    }
    

    [Route("BuildingService/get")]
    public async Task<IEnumerable<BuildingService>> GetBuildingServices()
        => await _db.BuildingServices
            .Include(x => x.BuildPhases)
            .ToArrayAsync();  
    
    [Route("BuildingServiceContract/get")]
    public async Task<IEnumerable<BuildingServiceContract>> GetBuildingServiceContracts()
        => await _db.BuildingServiceContracts
            .Include(x => x.Contract)
            .Include(x => x.Estimate)
            .Include(x => x.Order)
            .Include(x => x.BuildPhaseContracts)
            .ToArrayAsync(); 
    
    [Route("BuildPhase/get")]
    public async Task<IEnumerable<BuildPhase>> GetBuildPhases()
        => await _db.BuildPhases
            .Include(x => x.BuildingService)
            .ToArrayAsync();
    
    [Route("BuildPhaseContract/get")]
    public async Task<IEnumerable<BuildPhaseContract>> GetBuildPhaseContracts()
        => await _db.BuildPhaseContracts
            .Include(x => x.BuildPhase)
            .Include(x => x.BuildingServiceContract)
            .ToArrayAsync();
    
    [Route("Client/get")]
    public async Task<IEnumerable<Client>> GetClients()
        => await _db.Clients
            .Include(x => x.User)
            .ToArrayAsync(); 
    
    [Route("Contract/get")]
    public async Task<IEnumerable<Contract>> GetContracts()
        => await _db.Contracts
            .Include(x => x.Client)
            .Include(x => x.Employee)
            .Include(x => x.Receipt)
            .Include(x => x.BuildingServices)
            .ToArrayAsync(); 
    
    [Route("Employee/get")]
    public async Task<IEnumerable<Employee>> GetEmployees()
        => await _db.Employees
            .Include(x => x.User)
            .ToArrayAsync(); 
    
    [Route("Estimate/get")]
    public async Task<IEnumerable<Estimate>> GetEstimates()
        => await _db.Estimates
            .Include(x => x.Materials)
            .Include(x => x.BuildingServices)
            .ToArrayAsync();

    [Route("Material/get")]
    public async Task<IEnumerable<Material>> GetMaterials()
        => await _db.Materials
            .Include(x => x.Estimate)
            .ToArrayAsync();
    
    [Route("Order/get")]
    public async Task<IEnumerable<Order>> GetOrders()
        => await _db.Orders
            .Include(x => x.Client)
            .Include(x => x.BuildingServices)
            .ToArrayAsync(); 
    
    [Route("Receipt/get")]
    public async Task<IEnumerable<Receipt>> GetReceipts()
        => await _db.Receipts
            .Include(x => x.Client)
            .ToArrayAsync();  
    
    [Route("User/get")]
    public async Task<IEnumerable<User>> GetUsers()
        => await _db.Users.ToArrayAsync();
}