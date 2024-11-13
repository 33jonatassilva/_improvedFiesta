using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyFirstAPI.Model
{

    [Table("Employee")]
    [PrimaryKey("Id")]
    public class Employee
    {

        public Guid Id { get; private set; } =  new Guid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }

        public Employee() {}
        public Employee(string name, int age, string photo)
        {
            Name = name;
            Age = age;  
            Photo = photo;
        }
    }
}
