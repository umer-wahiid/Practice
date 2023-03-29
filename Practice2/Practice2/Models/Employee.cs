using System.ComponentModel.DataAnnotations;

namespace Practice2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }


        [Required(ErrorMessage="Name is Required")]
        [Display(Name="Employee Name")]
        [StringLength(20,ErrorMessage="Maximum 20 Characters Allowed")]
        [MinLength(3, ErrorMessage = "Min 3 Characters Allowed")]
        public string EName { get; set; }
        
        
        [Required(ErrorMessage="Father Name is Required")]
        [Display(Name="Employee Father Name")]
        [StringLength(20,ErrorMessage="Maximum 20 Characters Allowed")]
        [MinLength(3, ErrorMessage = "Min 3 Characters Allowed")]
        public string FName { get; set; }


        [DataType(DataType.EmailAddress, ErrorMessage = "Wrong Format")]
        [StringLength(20, ErrorMessage = "Maximum 20 Characters Allowed")]
        [MinLength(3, ErrorMessage = "Min 3 Characters Allowed")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Qualification is Required")]
        [StringLength(100, ErrorMessage = "Maximum 100 Characters Allowed")]
        public string Qualification { get; set; }
        
        
        [StringLength(100, ErrorMessage = "Maximum 100 Characters Allowed")]
        public string Skills { get; set; } = string.Empty;


        public Boolean IsActive { get; set; }

    }
}
