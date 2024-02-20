using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
        public string? EmployeeFirstName
        {
            get;
            set;
        }
        public string? EmployeeLastName
        {
            get;
            set;
        }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Salary
        {
            get;
            set;
        }
        public string? Designation
        {
            get;
            set;
        }
    }
}
