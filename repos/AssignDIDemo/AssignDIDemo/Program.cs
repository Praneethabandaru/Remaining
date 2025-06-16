using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Unity;

namespace AssignDIDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustService cs = new CustService();
            ServiceUser su = new ServiceUser(cs);
            su.addNshow();


            //var ser = new ServiceCollection();
            //ser.AddKeyedScoped<ICustomer, CustService>("hello"); 

            //var ServiceProvider = ser.BuildServiceProvider();
            //using (var scope1 = ServiceProvider.CreateScope())
            //{
            //    var service1 = scope1.ServiceProvider.GetRequiredService<ICustomer>();
            //    service1.AddCustomer(c);
            //    service1.DisplayCustomer(c.ToList());

            //    var service2 = scope1.ServiceProvider.GetRequiredKeyedService<ICustomer>("hello");
            //    service1.AddCustomer(c);

            //}

            //using (var scope2 = ServiceProvider.CreateScope())
            //{
            //    var service3 = scope2.ServiceProvider.GetService<ICustomer>();
            //    service3.AddCustomer(c);
            //}

        }
    }
}
