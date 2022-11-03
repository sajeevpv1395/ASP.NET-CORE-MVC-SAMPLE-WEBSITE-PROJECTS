using System.ComponentModel.DataAnnotations;

namespace mvcfull_operation.Models
{
    public class Usermanagement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }

        public string Qualification { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Place { get; set; }


    }
}
