using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Этап строительства в договоре", DisplayNamePlural = "Этапы строительства в договоре", Description = "Выборка этапов строительства в договоре")]
public class BuildPhaseContract
{
    public int id { get; set; }
  
    public int BuildPhaseId { get; set; }
    public virtual BuildPhase BuildPhase { get; set; }
    
    public bool IsDone { get; set; }
    
    public int BuildingServiceContractId { get; set; }
    public virtual BuildingServiceContract BuildingServiceContract { get; set; }
}