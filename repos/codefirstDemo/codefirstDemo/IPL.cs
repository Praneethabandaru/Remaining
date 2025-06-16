using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codefirstDemo
{
    public class IPL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please enter teamid")] 
        public int TeamID { get; set; }

        [Column("TeamName",TypeName = "Varchar")]  //we will get as TeamName in our sql server 
        [MaxLength(20)]
        public string Tname { get; set; }

        [Range(100000,300000,ErrorMessage = "Invalid Budget")]
        public int Budget {  get; set; }
        [Column("TeamState", TypeName = "Varchar")] 
        [MaxLength(50)]
        public string State { get; set; }

        [Column("Captain",TypeName = "Varchar")]
        [MaxLength(20)]
        public string Cap { get; set; }


    }
}
