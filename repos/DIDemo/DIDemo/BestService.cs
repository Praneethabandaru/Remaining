using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    internal class BestService :IMath
    {
        //better version of service class 
        public void Add(int a,int b)
        {
            Console.WriteLine($"The Sum is {a} and {b} is {a+b}");
        }
    }
}
