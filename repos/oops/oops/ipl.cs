using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class ipl
    {
        public string teamname { get; set; }

        public string captain { get; set; }

        public int budget { get; set; }

        //behaviour
        public void printdetail()
        {
            Console.WriteLine($"teamname-{teamname}");
            Console.WriteLine($"captain-{captain}");
            Console.WriteLine($"budget-{budget}");
        }
    }
}
