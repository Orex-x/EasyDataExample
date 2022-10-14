namespace EasyDataExample.Models;

public class Estimate
{
    public int Id { get; set; }
    public int Price { get; set; }
    public virtual ICollection<BuildingService> BuildingServices { get; set; }
}