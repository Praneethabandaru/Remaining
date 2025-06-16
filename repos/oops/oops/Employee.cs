using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Employee
    {
        //variable
        
        //properties supports validations,formatting
        int a;
        public int age
        {
            //you cannot write a logic directly
            //set block
            set
            {
                a = value;
                while (a < 0 || a > 120)
                {
                    Console.WriteLine("Re-enter the age");
                    a = int.Parse(Console.ReadLine());
                }
            }
            get
            {
                //write a logic to return,get block must have return keyword                          
                return a;
            }
        }
        string b;
        public string name
        {
            set
            {
                b = value;
                while (!b.StartsWith("s") || b.Length < 5)
                {
                    Console.WriteLine("re enter the name");
                    b = Console.ReadLine();
                }
               
            }
            get
            {
                return b.ToUpper(); 
            }
        }

        //shortcut for full property is propfull
        private string add;
        public string address
        {
            set 
            {
                add = value;
                do
                {

                    if (add == "chennai" || add == "hyderabad" || add == "banglore")
                    {
                        Console.WriteLine("valid address");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("re enter the address");
                        add = Console.ReadLine();
                    }
                }while(true); 
            }
            get
            { 
                return add;
            }
            
        }
        //automatic properties 
        //without validation use auto properties
        public int id { set; get; }

        public int MyProperty { get; set; }
    }
   
}
