using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Car
    {
        public string carname { get; set; } 
        public int carcapacity { get; set; }
        public string brand { get; set; }

        public void displaycardetails()
        {
            Console.WriteLine($"Car Name-{carname}");
            Console.WriteLine($"Car Capacity-{carcapacity}");
            Console.WriteLine($"Car Brand-{brand}");
        }

    }
}
