using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyDataExample.Models;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [Column(TypeName = "Date")]
    public DateTime DateTime { get; set; }
    public Client Client { get; set; }
    public virtual ICollection<BuildingService> BuildingServices { get; set; }
}