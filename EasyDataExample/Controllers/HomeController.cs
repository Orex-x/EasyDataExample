using EasyDataExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyDataExample.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _db;
    
    public HomeController(AppDbContext context)
    {
        _db = context;
    }

    public IActionResult Index()
    {
        return EasyData();
    }
    
    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult EasyData()
    {
        return View();
    }
}