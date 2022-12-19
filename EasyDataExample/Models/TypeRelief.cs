using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Тип рельефа", DisplayNamePlural = "типы рельефов", Description = "Выборка типов рельефов")]
public class TypeRelief
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}