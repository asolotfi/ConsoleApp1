using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class EmployeeTerritory
    {
        [Key, Column(Order = 0)]
        public int EmployeeID { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(20)]
        public string TerritoryID { get; set; }


        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }


        [ForeignKey("TerritoryID")]
        public Territory Territory { get; set; }
    }
}
