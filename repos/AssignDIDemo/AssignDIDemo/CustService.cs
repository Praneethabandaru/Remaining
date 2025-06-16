using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignDIDemo
{
    interface ICustomer
    {
        void AddCustomer(customer obj);
        void DisplayCustomer(List<customer> obj);
    }
    internal class CustService : ICustomer
    {
        b248dbEntities1 ob = new b248dbEntities1();
        
        public void AddCustomer(customer c)
        {
           
            ob.customers.Add(c);
            var res = ob.SaveChanges();
            Console.WriteLine("total rows inserted is" +res);
        }
        public void DisplayCustomer(List<customer> customers)
        {
            var res = from t in ob.customers
                      select t; 
            foreach (var item in res)
            {
                Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
            }

        }
    }
}
