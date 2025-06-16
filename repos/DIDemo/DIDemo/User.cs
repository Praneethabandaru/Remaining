using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    internal class User
    {
        //IMath m;
        //public User(IMath i)
        //{
        //    m = i;
        //}

        

        //this is a class which consumes service class
        //call add method 

        //Service ob = new Service();

        public IMath MyServiceInstance { get; set; }
        public void Show()
        {
            //m.Add(10, 20);
            MyServiceInstance.Add(10, 10);
        }
    }
}
