using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EasyManageWeb.Models;

[PrimaryKey("Id")]
public class Sale
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string ClientId { get; set; } 
    public string EmployeeId { get; set; }

    public List<SaleItems> SaleItems { get; set; } = new List<SaleItems>();
    
    
    [ForeignKey("ClientId")]
    private Client Client { get; set; }  // A classe Client deve estar definida

    [ForeignKey("EmployeeId")]
    private Employee Employee { get; set; }  // A classe Employee deve estar definida
}