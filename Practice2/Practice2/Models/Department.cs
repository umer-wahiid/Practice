using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2.Models
{
    public class Department
    {
        [Key]
        [ForeignKey("Employee")]
        public int DId { get; set; }

        [StringLength(50)]
        public string DName { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }
    }
}
