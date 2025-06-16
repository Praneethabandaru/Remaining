using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    interface IMath
    {
        void Add(int a, int b);
    }
    internal class Service : IMath
    {
        Guid g; 
        //this is a class contains bilogic(dbmethods,filehandling)
        public Service() 
        { 
            g = Guid.NewGuid();
        }

        public void Add(int a ,int b)
        {
            Console.WriteLine(g);
            Console.WriteLine(a+b);

        }
    }
}
