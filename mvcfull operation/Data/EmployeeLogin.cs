using System.ComponentModel.DataAnnotations;

namespace mvcfull_operation.Data
{
    public class EmployeeLogin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
       
    }
}
