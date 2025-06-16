using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class MyMathcls
    {
        public static void Add()
        {
            //string i= Console.ReadLine();
            // Console.WriteLine(i);



            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);

            //Console.WriteLine("the sum of " +a +" and " +b +" is " +c);
            //Console.WriteLine("the sum of {0} and {1} is {2}",a,b,c);
            //Console.WriteLine($"the sum of {a} and {b} is {c}");
        }
        public static void greatest()
        {
            //accepting 2 numbers and finding the greatest
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"a is greatest");
            }
            else
            {
                Console.WriteLine($"b is greatest");
            }
        }
    }
}
