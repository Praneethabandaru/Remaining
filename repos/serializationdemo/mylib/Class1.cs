using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib
{
    public class mycls
    {
        public int custid { get; set; }
        public int custname { get; set; }

        public void Method1()
        {
            Console.WriteLine("Method1 called");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 called");
        }
        public void Add(int a, int b)
        {
            Console.WriteLine("Add method called");
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Sub method called");
            Console.WriteLine(a - b);
        }
    }
}
