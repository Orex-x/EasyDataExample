using System.ComponentModel.DataAnnotations.Schema;
using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

public enum ContractStatus
{
    NEW,
    ACCEPT,
    COMPLETED
}

[MetaEntity(DisplayName = "Договор", DisplayNamePlural = "Договоры", Description = "Выборка договоров")]
public class Contract
{
    public int Id { get; set; }

    public string Number { get; set; }

    public string Address { get; set; }

    [Column(TypeName = "Date")]
    public DateTime DeadLine { get; set; }

    public int? ClientId { get; set; }
    public virtual Client Client { get; set; }

    public int? EmployeeId { get; set; }
    public virtual Employee? Employee { get; set; }

    public ContractStatus ContractStatus { get; set; }


    [Column(TypeName = "Date")]
    public DateTime? DateTimeNew { get; set; }
    [Column(TypeName = "Date")]
    public DateTime? DateTimeAccept { get; set; }
    [Column(TypeName = "Date")] 
    public DateTime? DateTimeCompleted { get; set; }

    public virtual ICollection<BuildingServiceContract> BuildingServices { get; set; }


    public int? ReceiptId { get; set; }
    public virtual Receipt? Receipt { get; set; }
}