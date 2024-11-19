using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [StringLength(5)] // اندازه ثابت برای CustomerID
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; } = 0; // مقدار پیش‌فرض

        [StringLength(40)]
        public string ShipName { get; set; }

        [StringLength(60)]
        public string ShipAddress { get; set; }

        [StringLength(15)]
        public string ShipCity { get; set; }

        [StringLength(15)]
        public string ShipRegion { get; set; }

        [StringLength(10)]
        public string ShipPostalCode { get; set; }

        [StringLength(15)]
        public string ShipCountry { get; set; }

        [ForeignKey("CustomerID")]
        public Customerr Customer { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        [ForeignKey("ShipVia")]
        public Shipper Shipper { get; set; }
        public List<Order> Orders { get; set; }
    }
}
