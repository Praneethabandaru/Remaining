using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//secnario:1.shared database connections 
//         2.any configuration which is common for all the users 

//how to create singleton object?
//1.Make sure that the class is sealed (sealed-which cannot be inhertied)
//2.Make the class constructor private
//3.Create static property to generate instance
namespace GOFPattern 
{
    internal sealed class Singleton
    {
        //how to create only 1 object,irrespective of number of users 
        //using class instances ]
        private Singleton() { }

        static Singleton s = null;

       //return the instance

        public static Singleton Instance 
        {
            get
            {
                if(s == null)
                {
                    s= new Singleton();
                    return s;
                }
                else
                {
                    return s;
                }
            }
        }
        public void Method()
        {
            //code to interact with databse
            Console.WriteLine("database code triggered");
        }

    }
}
