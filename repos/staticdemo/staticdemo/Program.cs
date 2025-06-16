using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using staticdemo;

namespace staticdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //code to call static
            //staticdemo1 ob = new staticdemo1(); - this is not possible bcz for static class we cant create the object
            /* 
             Console.WriteLine("age: "+staticdemo1.age);
             Console.WriteLine(staticdemo1.x);
             staticdemo1.hi();
            */
            #endregion

            #region //code to call consturctor
            //testcon ob1 = new testcon();
            //testcon ob2 = new testcon();
            //testcon ob3 = new testcon();
            //testcon ob4 = new testcon();
            //testcon ob5 = new testcon();


            //below the the pie vlaue is getting duplicated
            //calccls ob = new calccls();
            //calccls.Formula = 3.14;
            ////ob.Formula = 3.14;//cant be called using object bcz the variable is sttaic
            //ob.Radius = 10;
            //ob.CalculateArea();

            //calccls ob1= new calccls();
            ////ob1.Formula = 3.14;
            //ob1.Radius = 5;
            //ob1.CalculateArea();
            #endregion


            //languagefeature l = new languagefeature();
            //l.dynamicdemo(10);

            //Tuple<int, string> t = l.getdata();
            //Console.WriteLine(t.Item1);
            //Console.WriteLine(t.Item2);

            //l.display();

            //int k = 10;
            //Console.WriteLine(k.IsEven());

            //string s = "100";
            //int x = s.tointeger();
            //Console.WriteLine(x);

            //x1 ob = new x1();
            //int c = ob.add(10, 20);
            //Console.WriteLine(c);

            //p1 ob = new p1();
            //ob.Sub();
            //ob.Add();
            //ob.multiply();
            //ob.divide();

            //assign ob = new assign();
            //ob.SplitfullName("John Doe");

            //Employee emp = new Employee("John Doe", "IT", 50000);
            //Console.WriteLine(emp.GetDetails());

            //Manager mgr = new Manager("Jane Smith", "HR", 70000, 10);
            //Console.WriteLine(mgr.GetDetails());

           b ob = new b();
           int count = ob.EventCount();
           Console.WriteLine("Even Count: " + count);



        }
    }
}
