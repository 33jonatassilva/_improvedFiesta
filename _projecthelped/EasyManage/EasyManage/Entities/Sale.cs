using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EasyManage.Entities;

[PrimaryKey("Id")]
public class Sale
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ClientId { get; set; }
    public Guid EmployeeId { get; set; }

    public List<SaleItems> SaleItems { get; set; } = new List<SaleItems>();git
    
    
    [ForeignKey("ClientId")]
    public Client Client { get; set; }  // A classe Client deve estar definida

    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }  // A classe Employee deve estar definida
}