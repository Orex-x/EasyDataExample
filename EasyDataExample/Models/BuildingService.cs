namespace EasyDataExample.Models;

public class BuildingService
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Grade { get; set; }
    public virtual ICollection<BuildPhase> BuildPhases { get; set; }
}