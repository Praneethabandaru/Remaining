using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AssignCodeFirst
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int DeptId { get; set; }
        [Required]
        [MaxLength(20)]
        [RegularExpression("^(Finance|HR)$", ErrorMessage = "Department should be hr or finance")]
        public string DeptName { get; set; }
        [MaxLength(20)]
        public string Manager { get; set; }
        [Timestamp]
        public byte[] DeptEdit { get; set; }
    }
}