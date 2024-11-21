using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }

        [Key, Column(Order = 1)]
        public int ProductID { get; set; }

        [Column(TypeName = "money")]
        [Range(0, double.MaxValue, ErrorMessage = "UnitPrice must be non-negative.")]
        public decimal UnitPrice { get; set; } = 0;

        [Range(1, short.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public short Quantity { get; set; } = 1;

        [Range(0, 1, ErrorMessage = "Discount must be between 0 and 1.")]
        public float Discount { get; set; } = 0;

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
   
    
    }
}
