using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class MyCustomers
    {
        b248dbEntities ob = new b248dbEntities();
        public void ShowCustomer()
        {
            //should display all customers details

            var res = from t in ob.customers //customers is an property file
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
            }
        }
        public void displaybyid()
        {
            //searching by id
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            var res = (from t in ob.customers //customers is an property file
                      where t.custid == id
                      select t).FirstOrDefault();

            Console.WriteLine($"{res.custid} {res.custname} {res.dob} {res.caddress} {res.cphone}");
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
            //}
        }
        public void InsertCustomer()
        {
            //how to add new customer

            customer c = new customer()
            {
                custid = 1400,
                custname = "Eliyaz",
                dob = DateTime.Parse("01-02-1990"),
                caddress = "ap",
                cphone="789114451"
            };

            ob.customers.Add(c);
            var rows = ob.SaveChanges(); //updating to database
            Console.WriteLine("The total rows inserted is :" +rows);
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            var res = (from t in ob.customers //customers is an property file
                       where t.custid == id
                       select t).FirstOrDefault();
            ob.customers.Remove(res);
            var rows = ob.SaveChanges();
            Console.WriteLine("Total rows deleted is : "+rows);
        }
        public void UpdateCustomer()
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            var res = (from t in ob.customers //customers is an property file
                       where t.custid == id
                       select t).FirstOrDefault();

            res.caddress = "Andhra Pradesh";
            res.cphone = "5753444432";
            var rows = ob.SaveChanges();
            Console.WriteLine("total rows updated is : "+rows);
        }
    }
}
