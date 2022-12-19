using System.ComponentModel.DataAnnotations.Schema;
using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

public enum ContractStatus
{
    NEW,
    NOT_ACCEPT,
    ACCEPT,
    PENDING,
    COMPLETED
}

[MetaEntity(DisplayName = "Договор", DisplayNamePlural = "Договоры", Description = "Выборка договоров")]
public class Contract
{
    public int Id { get; set; }

    public string Number { get; set; }
    
    public string Address { get; set; }

    public DateTime DeadLine { get; set; }

    public int? ClientId { get; set; } = null;
    public virtual Client Client { get; set; }
    
    public int? EmployeeId { get; set; } = null;
    public virtual Employee? Employee { get; set; }

    public ContractStatus ContractStatus { get; set; }
    
    public DateTime? DateTimeNew { get; set; }
    public DateTime? DateTimeAccept { get; set; }
    public DateTime? DateTimeCompleted { get; set; }
    
    public virtual BuildingServiceContract BuildingServiceContract { get; set; } 
    
    public int? ReceiptId { get; set; } = null;
    public virtual Receipt? Receipt { get; set; }
}