using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal class Base
    {
        public Base(int x)
        {
            Console.WriteLine("this is from base class");
        }
    }
    internal class Derived :Base
    {
        public Derived(int x) :base(100)
        {
            Console.WriteLine("this is from derived class");
        }
    }
}
