using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal interface IMath
    {
       void Add(int a, int b);
        void Sub(int a, int b); 
    }
    internal interface IMath1
    {
        void Add(int a, int b);
        void Multiply(int a, int b);
        void Divide(int a, int b);
    }
    class mymath : IMath, IMath1
    {
        //explicit interface declaration 
       void IMath.Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
       void IMath1.Add(int a, int b)
        {
            Console.WriteLine("the sum is" +a + b);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);

        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);

        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
