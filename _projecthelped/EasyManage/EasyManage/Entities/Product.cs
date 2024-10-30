using System.ComponentModel.DataAnnotations;

namespace EasyManage.Entities;


public class Product
{   
    public Guid Id { get; set; } = Guid.NewGuid();
    [MinLength(3)]
    [MaxLength(50)]
    public string Name { get; set; }
    [MinLength(3)]
    [MaxLength(100)]
    public string Description { get; set; }
    public double Price { get; set; }
}