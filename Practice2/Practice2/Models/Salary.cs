using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice2.Models
{
        [Table("TblSalary")]
    public class Salary
    {

        [Key]
        public int SId { get; set; }

        [StringLength(20)]
        public string SMonth { get; set; }

        public int SAmount { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime SDate { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee{ get; set; }
    }
}
