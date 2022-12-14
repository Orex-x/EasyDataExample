using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Строительная услуга в договоре", DisplayNamePlural = "Строительные услуги в договоре", Description = "Выборка строительных услуг в договоре")]
public class BuildingServiceContract
{
    public int Id { get; set; }
    public int? Grade { get; set; }

    public int? TypeClimaticConditionId { get; set; }
    public TypeClimaticCondition? TypeClimaticCondition { get; set; }

    public int? TypeGroundId { get; set; }
    public TypeGround? TypeGround { get; set; }

    public int? TypeReliefId { get; set; }
    public TypeRelief? TypeRelief { get; set; }


    public int BuildingServiceId { get; set; }
    public virtual BuildingService BuildingService { get; set; }

    public int? ContractId { get; set; } 
    public virtual Contract? Contract { get; set; }
    
    public int? PriceEstimate { get; set; }
    
    public virtual ICollection<BuildingServiceMaterial> Materials { get; set; }
    
    public virtual ICollection<Stage> Stages { get; set; }
}