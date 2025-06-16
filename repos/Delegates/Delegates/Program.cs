using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.delrealtimecls;
//using System.Linq;

namespace Delegates
{
    internal class Program
    {
        //public static bool Mylogic(int x)
        //{
        //    return x > 50;
        //}
        static void Main(string[] args)
        {
            /* 
             myrealdel d = Mylogic;

            //deldemocls ob = new deldemocls();
            //ob.show(10);
            //ob.show(11);

            delrealtimecls ob = new delrealtimecls();

            int[] data = { 10, 20, 30, 40, 50, 60 };
            //ob.FilterMethod(data,d);  
            //ob.FilterMethod(data,(x) => { return x > 50; }); //this is called lambda expression
            ob.FilterMethod(data, (x) => x > 50 && x < 90);
            ob.FilterMethod(data, (x) => x > 50 && x < 90 || x>120);

            List<int> l = new List<int>();
            l.Add(10);
            */

            //multicastdemo multicastdemo = new multicastdemo();
            //multicastdemo.display();
            //Console.Read(); 
            //multicastdemo.show();
            //multicastdemo.callgen(); 

            bulitindecls ob = new bulitindecls();
            ob.display();

        }
    }
}
