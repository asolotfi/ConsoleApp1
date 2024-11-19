using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class CustomerDemographic
    {
        [Key]
        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        public string CustomerDesc { get; set; }

        public List<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
