using System.ComponentModel.DataAnnotations;
using System.Data;
using EasyManage.Enums;
using EasyManage.Models;

namespace EasyManage.Models;

public class Client : People
{
    public DateTime LastPurchase { get; set; }
    public EClientBudgetRate EClientBudgetRate { get; set; } = EClientBudgetRate.NewClientNoRate;


    public override string ToString()
    {
        return $"Id: {Cpf}\n" +
               $"Name: {FirstName} {LastName}\n" +
               $"BirthDate: {BirthDate}\n" +
               $"LastPurchase: {LastPurchase}\n" +
               $"ClientBudgetRate: {EClientBudgetRate}";
    }
}