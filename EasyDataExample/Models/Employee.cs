using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;


public enum Role
{
    Technical,
    Production,
    Supply,
    Contractual
}


[MetaEntity(DisplayName = "Сотрудник", DisplayNamePlural = "Сотрудники", Description = "Выборка сотрудникв")]
public class Employee
{
    public int Id { get; set; }
    public string INN { get; set; }
    public string PassportSeries { get; set; }
    public string PassportNumber { get; set; }

    public Role Role { get; set; }
    
    public int UserId { get; set; }
    public virtual User User { get; set; }
}