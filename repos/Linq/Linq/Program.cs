using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinqDemo l = new LinqDemo();
            //l.Demo1();
            //l.Demo2();
            //l.Demo3();
            //l.Demo4();
            //l.Demo5();

            Person p = new Person() { Name = "John", Age = 30, Address = new Address { City = "New York" } };

            //CODE TO CALL SHALLOW COPY
            //Person copy = p.ShallowCopy();
            //p.Name = "jay";
            //p.Age = 22;
            //p.Address.City = "London"; //ORIGINAL VALUE ALSO CHANged

            //p.Display();
            //copy.Display();

            //code to call deep copy
            ///============================

            Person copy = new Person(p);
            p.Display();
            copy.Display(); 


            //Console.WriteLine($"{p.Name} {p.Age} {p.Address.City} ");
            //Console.WriteLine($"{copy.Name} {copy.Age} {copy.Address.City}");


        }
    }
}
