using System.ComponentModel.DataAnnotations;

namespace EasyManage.Models
{
    public abstract class People
    {
        [Key]
        [Required]
        [StringLength(14, ErrorMessage = "CPF must be 14 characters long.")]
        public string Cpf { get; set; }

        [MinLength(3)]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }
    }
}