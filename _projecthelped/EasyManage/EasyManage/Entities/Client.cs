using System.ComponentModel.DataAnnotations;
using EasyManage.Enums;

namespace EasyManage.Entities;

public class Client
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [MinLength(3)]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [MinLength(3)]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    public DateTime LastPurchase { get; set; }
    public ClientBudgetRate ClientBudgetRate { get; set; }
}