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
    
    #region GET
    [Route("BuildingService/get")]
    public async Task<IEnumerable<BuildingService>> GetBuildingServices()
        => await _db.BuildingServices
            .ToArrayAsync();  
    
    [Route("BuildingServiceContract/get")]
    public async Task<IEnumerable<BuildingServiceContract>> GetBuildingServiceContracts()
        => await _db.BuildingServiceContracts
            .Include(x => x.Contract)
            .Include(x => x.Materials)
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
            .Include(x => x.BuildingServiceContract)
            .ToArrayAsync(); 
    
    [Route("Employee/get")]
    public async Task<IEnumerable<Employee>> GetEmployees()
        => await _db.Employees
            .Include(x => x.User)
            .ToArrayAsync(); 
   

    [Route("Material/get")]
    public async Task<IEnumerable<Material>> GetMaterials()
        => await _db.Materials
            .Include(x => x.BuildingServiceContract)
            .ToArrayAsync();
    
    
    [Route("Receipt/get")]
    public async Task<IEnumerable<Receipt>> GetReceipts()
        => await _db.Receipts
            .Include(x => x.Client)
            .ToArrayAsync();  
            
    [Route("TypeClimaticCondition/get")]
    public async Task<IEnumerable<TypeClimaticCondition>> GetTypeClimaticConditions()
        => await _db.TypeClimaticConditions.ToArrayAsync();
    
    [Route("TypeGround/get")]
    public async Task<IEnumerable<TypeGround>> GetTypeGrounds()
        => await _db.TypeGrounds.ToArrayAsync();
    
    [Route("TypeRelief/get")]
    public async Task<IEnumerable<TypeRelief>> GetTypeReliefs()
        => await _db.TypeReliefs.ToArrayAsync();
    
    [Route("User/get")]
    public async Task<IEnumerable<User>> GetUsers()
        => await _db.Users.ToArrayAsync();
    #endregion
}