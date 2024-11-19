using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Territory
    {
        [Key]
        [StringLength(20)]
        public string TerritoryID { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; } = string.Empty;

        [Required]
        public int RegionID { get; set; }

        [ForeignKey("RegionID")]
        public Region? Region { get; set; }
        public List<Employee> employees { get; set; }
    }
}
