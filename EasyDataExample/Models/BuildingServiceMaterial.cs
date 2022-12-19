using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Материалы в договоре", DisplayNamePlural = "Материалы в договоре", Description = "Выборка материалов в договоре")]
public class BuildingServiceMaterial
{
    public int Id { get; set; }

    public int Amount { get; set; }
    
    public int MaterialId { get; set; }
    public Material Material { get; set; }

    public int BuildingServiceContractId { get; set; }
    public virtual BuildingServiceContract BuildingServiceContract { get; set; }
}