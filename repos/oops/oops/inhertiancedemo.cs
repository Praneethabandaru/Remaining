using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class parent
    {
        public parent()
        {
            Console.WriteLine("parent default consturctor");

        }
        public parent(int x):this()//parameterized constructor
        {
            Console.WriteLine("child parameterised called");
        }
        public void hi()
        {
            Console.WriteLine("hi method from parent");

        }
    }
    class child:parent
    {
        public child():base(100) 
        {
            Console.WriteLine("child default constructor called");
        }
        public child(int x) :this()//calls parent class constructor
        {
            Console.WriteLine("child parameterized constructor called");
            //initialize global variables
        }
        public void hi()
        {
            Console.WriteLine("Hello from child class");
            base.hi();//calls base class method


        }

    }
}
