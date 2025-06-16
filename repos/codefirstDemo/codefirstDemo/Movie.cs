using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstDemo
{
    public class Movie
    {
        [Key] //specifying primary key 
        public int MovieID { get; set; }
        public string MovieName { get; set; }   
        public string Actor { get; set; } 
        public string Actress { get; set; } 
        public int YOR { get; set; }

    }
}
