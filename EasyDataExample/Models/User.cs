using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Пользователь", DisplayNamePlural = "Пользователи", Description = "Выборка пользователей")]
public class User
{ 
    public int Id { get; set; }
    
    [MetaEntityAttr(DisplayName = "Имя")]
    public string FirstName { get; set; }
    
    [MetaEntityAttr(DisplayName = "Отчество")]
    public string? MiddleName { get; set; }
    
    [MetaEntityAttr(DisplayName = "Фамилия")]
    public string LastName { get; set; }
    
    [MetaEntityAttr(DisplayName = "Логин")]
    public string Login { get; set; }
    
    [MetaEntityAttr(DisplayName = "Пароль", Editable = false ,ShowOnView = true, ShowInLookup = false)]
    public string Password { get; set; }
}