using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            collecdemo obj = new collecdemo();
            //obj.arraylistdemo1(); 

            //obj.arraylistdemo2();

            //obj.arraylistdemo3();

            //obj.arraylistdemo4(); 

            //obj.arraylistdemo5();

            //obj.Hashtabledemo();

            //obj.stackdmeo();

            //obj.qdemo();

            //obj.listdemo();

            //obj.dictionarydemo();

            //obj.listdemo1();

            //GenDemo ob = new GenDemo();
            //ob.swap<int>(10, 20);
            //ob.swap<string>("praneetha", "potti");
            //ob.swap("world", "hello");

            //GenDemo<int> ob= new GenDemo<int>();
            //ob.swap(10, 20);

            //geninter<int> o = new GenDemo<int>();
            //o.swap(10, 200);

            //testinggen<Products> ob=new testinggen<Products>();
            //testinggen <int> ob1 = new testinggen<int>();

            // EmployList emp = new EmployList();
            // emp.AddEmp("Praneetha");
            // emp.AddEmp("Praneesh");

            // //indexers is called via objects
            // //Console.WriteLine(emp[1]); //op:praneesh (solved this by using indexers)

            // //IEnumerator is for navigating through the collection 
            // IEnumerator e1 = emp.GetEnumerator();
            //e1.MoveNext();
            // Console.WriteLine(e1.Current); //praneetha
            // e1.MoveNext();
            // Console.WriteLine(e1.Current); //praneesh
            // e1.Reset(); //it is used to reset the enumerator to its initial position                                           
            // e1.MoveNext();
            // Console.WriteLine(e1.Current);

            //GetEnumerator methods provides support for for-each loop
            //foreach (var item in emp) 
            //{
            //    Console.WriteLine(item); 
            //}
            //emp.DisplayAll();

            assigndemo a = new assigndemo();
            //a.Hashdemo();

            a.listdemo();
            a.GetCustomerList();
            Console.WriteLine("===========");
            a.GetReport(Convert.ToDateTime("2000-01-01"), Convert.ToDateTime("2004-01-01"));
            Console.WriteLine("=======");
            a.GetById(101);
        }
    }
}
