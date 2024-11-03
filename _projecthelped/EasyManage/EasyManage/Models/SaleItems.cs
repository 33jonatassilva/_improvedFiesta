using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EasyManage.Models;

[PrimaryKey("Id")]
public class SaleItems
{
    public int Id { get; set; }
    public Guid SaleId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public double TotalValue { get; set; }
    
    [ForeignKey("SaleId")]
    public Sale Sale { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
}