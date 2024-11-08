using System.ComponentModel.DataAnnotations;

namespace EasyManage.Models;


public class Product
{   
    public Guid Id { get; private set; } = Guid.NewGuid();
    [MinLength(3)]
    [MaxLength(50)]
    public string Name { get; set; }
    [MinLength(3)]
    [MaxLength(100)]
    public string Description { get; set; }
    public double Price { get; set; }


    public override string ToString()
    {
        return $"\n\nId: {Id}\n" +
               $"Name: {Name}\n" +
               $"Description: {Description}\n" +
               $"Price: R${Price},00\n";
    }
}