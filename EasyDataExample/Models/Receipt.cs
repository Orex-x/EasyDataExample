using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Чек", DisplayNamePlural = "Чеки", Description = "Выборка чеков")]
public class Receipt
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public int BankAccountNumber { get; set; }
    public int Sum { get; set; }


}