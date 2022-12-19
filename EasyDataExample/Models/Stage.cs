using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;


[MetaEntity(DisplayName = "Этап", DisplayNamePlural = "Этапы", Description = "Выборка этапов")]
public class Stage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ActionName { get; set; }
    public string Status { get; set; }
    public string Ellipse { get; set; }
    
    public int BuildingServiceContractId { get; set; }
    public virtual BuildingServiceContract BuildingServiceContract { get; set; }
}