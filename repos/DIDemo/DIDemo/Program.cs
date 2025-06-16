using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Unity;

namespace DIDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ServiceCollection s = new ServiceCollection();
            var services = new ServiceCollection();
            //s.AddSingleton<IMath, Service>();
            services.AddScoped<IMath, Service>();

            var ServiceProvider = services.BuildServiceProvider(); 

            using (var scope1 = ServiceProvider.CreateScope())
            {
                var service1= scope1.ServiceProvider.GetService<IMath>();
                service1.Add(10,20);

                var service2 = scope1.ServiceProvider.GetService<IMath>();
                service2.Add(20,30);
            }

            using(var scope2 = ServiceProvider.CreateScope())
            {
                var service3 = scope2.ServiceProvider.GetService<IMath>();
                service3.Add(20,20);
            }

            //object creation,instance management all happens here

            //you need to use package in main function
            //(where ever object is created)

            //this is used to manage instance 
            //how many objects can be used by application 
            //1 or objects,many objects
            //UnityContainer c = new UnityContainer();
            //c.RegisterSingleton<IMath, Service>();
            //c.RegisterInstance<IMath>(new Service());
            //c.RegisterFactory<IMath>(obb => new Service());
            //wherever i use IMath,Interface,please pass the instance of service class
            //how do you call add method?

            //var obj1 = c.Resolve<IMath>();
            //var obj2 = c.Resolve<IMath>();
            //var obj3 = c.Resolve<IMath>();
            //obj1.Add(100, 200);
            //obj2.Add(100, 200);
            //obj3.Add(100, 200);
            //obj1.Add(100, 200);
            //obj2.Add(100, 200);
            //obj3.Add(100, 200);
            //var obj = c.Resolve<IMath>();
            //now service class object can be used using Resolve method 
            //(obj is an object of service class)        
            //obj.Add(10, 200); 

            //Guid guid = Guid.NewGuid();
            //Console.WriteLine(guid.ToString());

            //UnityContainer u = new UnityContainer();
            //u.RegisterSingleton<IMath,Service>("hi");
            //u.RegisterSingleton<IMath,BestService>("hello");

            //var obj = u.Resolve<IMath>("hello");
            //obj.Add(60, 80);

            //Service s = new Service();
            //BestService b = new BestService();
            //User u = new User(); 
            //u.MyServiceInstance = s;
            //u.Show();
            Console.ReadLine();
        }
    }
}
