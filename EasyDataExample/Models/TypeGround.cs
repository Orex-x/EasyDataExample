using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Тип грунта", DisplayNamePlural = "Типы грунтов", Description = "Выборка типов грунтов")]
public class TypeGround
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}