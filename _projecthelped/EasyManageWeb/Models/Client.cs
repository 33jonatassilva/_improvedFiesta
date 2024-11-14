using System.ComponentModel.DataAnnotations;
using System.Data;
using EasyManageWeb.Enums;
using EasyManageWeb.Models;

namespace EasyManageWeb.Models;

public class Client : People
{
    public DateTime LastPurchase { get; set; }
    public EClientBudgetRate EClientBudgetRate { get; set; } = EClientBudgetRate.NewClientNoRate;


    public override string ToString()
    {
        return $"\n\nCpf: {Cpf}\n" +
               $"Name: {FirstName} {LastName}\n" +
               $"BirthDate: {BirthDate}\n" +
               $"LastPurchase: {LastPurchase}\n" +
               $"ClientBudgetRate: {EClientBudgetRate}";

    }
}