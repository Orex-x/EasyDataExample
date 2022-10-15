using System.ComponentModel.DataAnnotations.Schema;
using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Договор", DisplayNamePlural = "Договоры", Description = "Выборка договоров")]
public class Contract
{
    public int Id { get; set; }
    
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
    
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
    
    [Column(TypeName = "Date")]
    public DateTime DateTime { get; set; }
    
    public virtual ICollection<BuildingServiceContract> BuildingServices { get; set; } 
    
    public int ReceiptId { get; set; }
    public virtual Receipt Receipt { get; set; }
}