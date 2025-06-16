using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Class1
    { 
        b248dbEntities dc = new b248dbEntities();
        public void Demo1()
        {
            var res = from t in dc.customers
                      select t;
            //ef will convert all linq queries to corresponding sql queries 

            //SqlCommand c = new("select * from customers");

            dc.Database.Log = Console.WriteLine; //this will display info + timings i mean how much time it took etc 

            foreach (var item in res)
            {
                //Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
                Console.WriteLine($"{item.custname}");
            }
        }

        //lazy loading  : it will not load the related data
        //eager loading : using parent table object i can also access child table data
        //explicity loading : you have to specify the table name

        public void Demo2()
        {
            dc.Database.Log = Console.WriteLine;
            //var res = from t in dc.customers
            //          select t;

            //loads only orders table
            var res = dc.customers.Include(c =>c.orders);
            //res is not only holding customer records + but it also holding child tables
            //res customers + child tables

            foreach (var item in res)
            {
                Console.WriteLine(item.custid +":" +item.custname);
                foreach (var item1 in item.orders)
                {
                    Console.WriteLine(item1.orderid +":" +item1.productname +":" +item.caddress);
                }
                Console.WriteLine("==============");
            }


        }
    }
}
