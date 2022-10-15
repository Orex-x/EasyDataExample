using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Этап строительства", DisplayNamePlural = "Этапы строительства", Description = "Выборка этапов строительства")]
public class BuildPhase
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public int BuildingServiceId { get; set; }
    public BuildingService BuildingService { get; set; }
    
}