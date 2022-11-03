using System.ComponentModel.DataAnnotations;

namespace mvcfull_operation.Models
{
    public class Signup
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Qualification { get; set; }

    }
}
