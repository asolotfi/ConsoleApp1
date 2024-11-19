
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? UnitPrice { get; set; } = 0;

        public short? UnitsInStock { get; set; } = 0;

        public short? UnitsOnOrder { get; set; } = 0;

        public short? ReorderLevel { get; set; } = 0;

        public bool Discontinued { get; set; } = false;

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
    }
}
