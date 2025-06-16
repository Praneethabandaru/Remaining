using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignDIDemo
{
    internal class ServiceUser
    {
        ICustomer m;
        customer c = new customer()
        {
            custid = 900,
            custname = "mani",
            dob = DateTime.Parse("07-06-2003"),
            caddress = "hyderabad",
            cphone = "7981749561"
        };
        public ServiceUser(ICustomer i)
        {
            m = i;
        }
        
        public void addNshow()
        {
            m.AddCustomer(c);
            var customers = new List<customer> { c };
            m.DisplayCustomer(customers);
        }


    }
}
