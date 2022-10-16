using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Клиент", DisplayNamePlural = "Клиенты", Description = "Выборка клиентов")]
public class Client
{
    public int Id { get; set; }
    public int Balance { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }
}