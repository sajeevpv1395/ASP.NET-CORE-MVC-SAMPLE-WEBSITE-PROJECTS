
using System.ComponentModel.DataAnnotations;
namespace mvcfull_operation.Models 
{
    public class UserLogin
    {
        [Key]
        public string Email { get; set; }
        public string Pasword { get; set; }
    }
}
