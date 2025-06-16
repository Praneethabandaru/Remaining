using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDemo
{
    internal class EfCls
    {
        b248dbEntities dc = new b248dbEntities();
        public void Demo1()
        {
            //it should call the procedure
            var res = dc.getcust(100);

            //var res = from t in dc.customers
            //where custid == id
            //select t;

            foreach (var item in res)
            {
                Console.WriteLine(item.custid +":" +item.custname); 
            }
        }
        public void Demo2()
        {
            //how to write sql queries in ef

            var res = dc.Database.SqlQuery<customer>("select * from customers where custid between 400 and 800");

            foreach (var item in res)
            {
                Console.WriteLine(item.custid + ":" + item.custname);
            }
        }
        public void Demo3()
        {
            //dml commands 
            var res = dc.Database.ExecuteSqlCommand("delete from customers where custid=900");

            Console.WriteLine("total rows deleted is "+res);
        }
        public void Demo4()
        {
            //generic repository

            customer c = new customer();
            c.custid = 900;
            c.custname = "vijay";
            c.dob = DateTime.Now;
            c.caddress = "hyd";
            c.cphone = "547687687";

           
            GenRepo g = new GenRepo();
            //g.Insert(c);
           

            //dc.customers.Add(c);
            //int i = dc.SaveChanges();

            //Console.WriteLine("Total records inserted is "+i);
        }
        GenRepo ob = new GenRepo();   
        public void Demo5()
        {
            var res = ob.Find<customer>(1400);
            //you can also print the values of res to display
            ob.Delete(res); 
        }
        public void Demo6()
        {
            
            var res1 = ob.top3<customer>(3);
            foreach (var item in res1)
            {
                Console.WriteLine(item.custname +item.custid);
            }

        }

    }
}
