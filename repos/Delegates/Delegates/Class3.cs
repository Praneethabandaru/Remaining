using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class bulitindecls
    {
        public void Add()
        {
            Console.WriteLine("Add called");
        }
        public void sub(int x)
        {
            Console.WriteLine("sub called" +x);
        }
        public string mul(int x, int y)
        {
            return "the sum is" + (x * y);
        }
        public double fact()
        {
            return 10.5;
        }
        public void display()
        {
            Action ob = Add;
            ob.Invoke();
            Console.WriteLine("==========");
            Action<int> ob1 = sub;
            ob1.Invoke(10);
            Console.WriteLine("=========");
            Func<int, int, string> ob2 = mul; //supports return type
            var res = ob2.Invoke(10, 20); 
            Func<double> ob3 = fact; //supports return type
            var res1 = ob3.Invoke();
            Console.WriteLine(res1);
            Console.WriteLine(res);
        }

    }
}
