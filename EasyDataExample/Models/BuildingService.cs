using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Строительная услуга", DisplayNamePlural = "Строительные услуги", Description = "Выборка строительных услуг")]
public class BuildingService
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    
    public virtual ICollection<BuildPhase> BuildPhases { get; set; }
}