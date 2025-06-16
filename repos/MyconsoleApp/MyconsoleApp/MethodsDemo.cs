using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class MethodsDemo
    {
        public static void valuetypedemo(int x)
        {
            x += 10;
            Console.WriteLine(x);//prints 110
        }
        public static void reftypedemo(ref int x)
        {
            x += 10;
            Console.WriteLine(x);.......
        }
        public static void outtypedemo(int a,int b, out int x,out int y)
        {
            x = a + b;
            y = a * b;
        }
        public static void optionaldemo(int a=10,int b=20)
        {
            Console.WriteLine(a + b);
            Console.WriteLine("optional called");
        }
        public static void optionaldemo()
        {
            Console.WriteLine("optional called");
        }
        public static void paramsdemo(int[] x)
        {
            foreach (var item in x)
            { 
                Console.WriteLine(item);
            }
        }
        
        public static void paramsdemo1(params int[] x)
        //a method can have only 1 params keyword can pass now (params int []x,params int[]y)
        //parameter array should be the always the last parameter of the function ==> public static void paramsdemo1(params int[] x,int y) this is error 
                                                          //instead we can say as ==> public static void paramsdemo1(int y,params int[] x) then params parameter will be tha last 
        {
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
        }

        public static void sum(params int[] x)//sum of two numbers or any numbers
        {
            int sum = 0;
            foreach (var item in x)
            {
                sum += item;
                //Console.WriteLine(item);
            }
            Console.WriteLine(sum);
        }



    }
}
