

using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Category
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }
        public List<Product> Products { get; set; }
    }
}
