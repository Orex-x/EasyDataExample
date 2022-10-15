using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Смета", DisplayNamePlural = "Смета", Description = "Выборка сметы")]
public class Estimate
{
    public int Id { get; set; }
    public int Price { get; set; }
    public virtual ICollection<BuildingServiceContract> BuildingServices { get; set; }
    public virtual ICollection<Material> Materials { get; set; }
}