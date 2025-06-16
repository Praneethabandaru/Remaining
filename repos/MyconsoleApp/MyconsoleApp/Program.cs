using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine("Good Morning!!!");
            //MyMathcls.Add();
            //MyMathcls.greatest();
            //Console.Read();
            day1 ob=new day1();
            //ob.greatestofthree();
            //ob.empdetails();
            //ob.Factorial();
            //ob.Sumof10Nums();
            //ob.Swapnums();
            //ob.divnums();
            //ob.copystring();
            //ob.printnames();
            //----------DAY_2----------
            //int m = 100;
            //MethodsDemo.valuetypedemo(m);
            //Console.WriteLine("m = "+m);
            //MethodsDemo.reftypedemo(ref m);
            //Console.WriteLine("m = " + m);

            //but if we use ref keyword intialzation is must int p=0 and int q=0 
            //in out keyword no need of initalization 
            //int p;
            //int q;
            //MethodsDemo.outtypedemo(5, 10,out p,out q);//same can be achieved through using ref keyword also but it need to intializa the values for p and q
            //Console.WriteLine(p); //prints sum
            //Console.WriteLine(q); //prints product

            //MethodsDemo.optionaldemo();//in optional demo if we dont pass parameters it will take the default values which we gave in method
            //MethodsDemo.optionaldemo(2,3);// we can also pass the parameters which will override the default values

            //MethodsDemo.optionaldemo(50);//we can pass only one value and another parameter will take by default value now a=50 but we cant give the value for b
            //MethodsDemo.optionaldemo(b:100);//so for giving value for b we use named parameters method here this can be achieved by giving the parameter name
            //MethodsDemo.optionaldemo(b: 100,a:50);//can pass it in any order

            //int[] a = { 10, 20, 30 };
            //MethodsDemo.paramsdemo(a);
            ////MethodsDemo.paramsdemo(102, 20, 30);//this is not possible we can pass values bcz it is accepting an array but it is jst like accepting diff para so to avoid that we declare an array and give values

            ////when we want to pass para directly i.e., that when you are not sure about parameters use params keyword so we can pass parameters as our wish
            //MethodsDemo.paramsdemo1(10,20,30,40);
            //MethodsDemo.paramsdemo1(10, 20);
            //MethodsDemo.paramsdemo1();

            //MethodsDemo.sum(1, 2);
            //MethodsDemo.sum(1, 2, 3);
            //MethodsDemo.sum(1, 2, 5,7,8,9);

            //ArrayDemo.singledimension1();
            //ArrayDemo.singledimension2();

            //ArrayDemo.multidimension1();
            //ArrayDemo.multidimension2();
            //ArrayDemo.Jaggeddemo(); 

            //s1 ob1 = new s1();
            //ob1.x = 100;
            //s1 ob2 = ob1;
            //Console.WriteLine(ob2.x); //100
            //ob2.x = 200; // any changes in the x value will not effect the original value
            //Console.WriteLine(ob2.x); //200
            //Console.WriteLine(ob1.x); //100 

            //Console.WriteLine("-------------");


            //c1 ob1 = new c1();
            //ob1.x = 100;
            //c1 ob2 = ob1;
            //Console.WriteLine(ob2.x); //100
            //ob2.x = 200; 
            //Console.WriteLine(ob2.x); //200
            //Console.WriteLine(ob1.x); //200

            //ArrayDemo.boxingdemo();
            //ArrayDemo.nullabledemo();
            ArrayDemo.pointerdemo();
        }

    }
}
