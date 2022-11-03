using System.ComponentModel.DataAnnotations;

namespace mvcfull_operation.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public int ProductQuanitity { get; set; }

        public int ProductPrice { get; set; }

    }
}
