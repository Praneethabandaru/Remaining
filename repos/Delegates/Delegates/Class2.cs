using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class2
    {
        //object inherited by every type
        //what is contravariance?
        //Contravariance allows a method to accept parameters that are less derived than the delegate's parameter type

        //what is Covariance?
        //-covariance allows a method to return a type that is more derived than the delegate's return type 
        public delegate void comethod(string s);//derived
        public delegate void comethod2();
        public void display()
        {
            string s = " hello world";
            object o = s; //valid
            comethod obj = testing; //object of delegate
            //comethod obj2 = testing1;
        }
        public void testing(object  s) //base type (contravariance)
        {
            //any logic goes here

        }
        public string testing1() //derived type covariance
        {
            //any logic goes here
            return "hello";

        }
    }
}
