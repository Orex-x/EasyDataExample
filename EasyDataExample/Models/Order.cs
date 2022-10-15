using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Заказ", DisplayNamePlural = "Заказы", Description = "Выборка заказов")]
public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Column(TypeName = "Date")]
    public DateTime DateTime { get; set; }
    
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
    
    public virtual ICollection<BuildingServiceContract> BuildingServices { get; set; }
}