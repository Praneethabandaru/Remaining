using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignCodeFirst;

namespace AssignCodeEmp
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Pls enter Empid")]
        [MaxLength(10)]
        [RegularExpression("^E[0-9]{3}$")]
        public string Empid { get; set; }
        [Required]
        [MaxLength(20)]
        public string EmpName { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        [Range(50000, 150000)]
        public int Salary { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public virtual Department Department { get; set; }
    }
}
