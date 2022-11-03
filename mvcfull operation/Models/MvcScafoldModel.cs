using System.ComponentModel.DataAnnotations;

namespace mvcfull_operation.Models
{
    public class MvcScafoldModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public int Price { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
