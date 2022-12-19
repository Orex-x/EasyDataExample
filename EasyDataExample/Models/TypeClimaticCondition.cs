using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Тип климатического условия", DisplayNamePlural = "Типы климатических условий", Description = "Выборка типов климатических условий")]
public class TypeClimaticCondition
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}