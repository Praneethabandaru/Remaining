using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // public delegate void mydel(int x); we can decale outside the class if delegate wants to use by multiple users 
    internal class deldemocls
    {
        //declaration 
        public delegate void mydel(int x); //normally,we use this inside the class outside the method
        //public void even(int x)
        ////{
        ////    Console.WriteLine(x +"even called");
        ////}
        public void odd(int x)
        {
            Console.WriteLine(x +"odd called");
        }
        public void show(int i)
        {
            mydel ob;
            if (i % 2 == 0)
            {
                //method-1
                //ob = new mydel(even); //instantantion

                //method-2
                //ob = even; //instantantion 

                //method-3 (anonymouse delegate assigning the logic without using the methodname)
                //ob = delegate (int x) 
                //{ 
                //    Console.WriteLine(x + "even called"); //this was introduced in the version 3.0
                //}; //instantantion

                //method-4 (lambda expression)
                ob = (x) => { Console.WriteLine(x + "even called"); }; //instantantion
            }
            else
            { 
                ob = new mydel(odd);
            }

            ob.Invoke(i); //invocation   
        }
    }
}
