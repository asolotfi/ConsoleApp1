using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class CustomerCustomerDemo
    {
        [Key, Column(Order = 0)]
        [StringLength(5)]
        public string CustomerID { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        // روابط خارجی
        [ForeignKey("CustomerID")]
        public Customerr Customer { get; set; }

        [ForeignKey("CustomerTypeID")]
        public CustomerDemographic CustomerDemographic { get; set; }
    }
}
