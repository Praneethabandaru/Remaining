using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticdemo
{
    public interface ITest
    {
        void hi();
    }
    //static doesnt support inhertiance and no object creation
    internal static class staticdemo1 //:subcls //:ITest-interface is also not possible  //we are decalring class as static then we need to decalre all the members as static only
    {
        public static int x; //variable has to be static
        public static void hi()
        {
            //method has to be static
            Console.WriteLine("hi function called");
              //this keyword cannot be used 
        }                                                                                                               
        public static int age { get; set; } = 10; //property-static

        static staticdemo1()
        {
            //constructor has to be static
            Console.WriteLine("constructor called");
        }
    }
    //class subcls:staticdemo1 cannot call like this 
    static class subcls
    {

    }

    class testcon ///if the class is static all the members is also static 
    {
        //both will be exectued but if both the constructors are there that is non-static and static then first preference is given to static and it will be called only once
        //this is called when a class is loading in the memory
        static testcon() //static constructor //cannot use no access specifier // cannot have an parameter bcz their is no place to pass the parameter-- leads to error static testcon(int x) {  }
        {
            //meant to initialize static variables 
            Console.WriteLine("static called");

            //databse connection code goes here bcz we need the commmon connection to be used by all the objects.
        }
        //instance called when object is created
        public testcon(int x) //instance constructor //can overlaod 
        {
            //meant to initialize non-static variables 
            Console.WriteLine("instance called");
        }
    }
    class calccls
    {
        public int Radius { get; set; }
        public static double Formula { get; set; } //static means only allocate once 

        public void CalculateArea() 
        {
            double d = Formula * Radius * Radius;
            Console.WriteLine("Area :" +d);
        }
    }

}
