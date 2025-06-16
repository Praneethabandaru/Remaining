using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCustomers ob = new MyCustomers();
            //ob.ShowCustomer();
            //ob.displaybyid();
            //ob.InsertCustomer();
            //ob.DeleteCustomer();
            //ob.UpdateCustomer();
            Myorders ob2 = new Myorders();
            //ob2.displayorders();
            //ob2.commonrecord();
            //ob2.displaytop3customers();
            //ob2.maxprice();
            //ob2.displayaddressblr();
            //ob2.displayIncreaseprice();
            //ob2.customersbirthday();
            Class1 c = new Class1();
            //c.Demo1();
            c.Demo2();
            Console.Read();
        }
    }
}
