using System.ComponentModel.DataAnnotations;

namespace MVCEmployees.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter a Name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Enter an Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
    }
}
