using System.ComponentModel.DataAnnotations.Schema;

namespace EasyDataExample.Models;

public class Contract
{
    public int Id { get; set; }
    public Client Client { get; set; }
    public Employee Employee { get; set; }
    
    [Column(TypeName = "Date")]
    public DateTime DateTime { get; set; }
    
    public virtual ICollection<BuildingService> BuildingServices { get; set; } 
}