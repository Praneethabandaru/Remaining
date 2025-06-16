using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class staticpolydemo
    {

        public void add(int x,int y)
        {
            Console.WriteLine($"the sum of int is {x+y}");
        }
        public void add(float x, float y)
        {
            Console.WriteLine($"the sum of float is {x + y}");
        }
        public void add(double x, double y)
        {
            Console.WriteLine($"the sum of double is {x + y}");
        }
    }
}
