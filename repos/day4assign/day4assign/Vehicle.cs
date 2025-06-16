using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("I love driving");
        }
    }
    class car:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("i love car ridess");
        }
    }
    class bike:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("hello from bike");
        }
    }
}
