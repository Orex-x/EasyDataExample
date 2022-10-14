namespace EasyDataExample.Models;

public class Employee
{
    public int Id { get; set; }
    public string INN { get; set; }
    public string PassportSeries { get; set; }
    public string PassportNumber { get; set; }
    public User User { get; set; }
}