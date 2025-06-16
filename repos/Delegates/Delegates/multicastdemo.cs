using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
  
    internal class multicastdemo
    {
        delegate void multidel();
        delegate string mydelstr();
        mydelstr ob;
        delegate void mygendel<T>(T x, T y);
        public void m1()
        {
            Console.WriteLine("m1 called");
        }
        public void m2()
        {
            Console.WriteLine("m2 called");
        }
        public string mydbMethod()
        {
            //returns some data from database 
            Thread.Sleep(5000); //returns after 5 sec
            return "name = POTTI age=23";
        }
        public void display()
        {
            //multicast delegate
            /*
            multidel ob = m1;
            ob += m2; //adds some function
            ob -= m1;// removes some function
            ob.Invoke(); //invocation
            */
            multidel ob1, ob2, ob3;

            ob1 = m1;
            ob2 = m2;
            ob3 = ob1 + ob2; //combining the delegates
            ob3.Invoke(); //invocation
        }
        public void show()
        {
            //ob3.Invoke(); //synchronous invocation(no threads are used)
            //synchronous means user has to wait 
            //ob2.BeginInvoke(); //asynchronous invocation(it uses threads)
            //asynchronous means user does not wait 
            //multidel ob;
            //ob = m1; //a function which uses database logic ,accessing remote system , it takes min 10 sec to return records
             ob = mydbMethod;
            //var res = ob.Invoke();
            var res = ob.BeginInvoke(showoutput,null);//run the method in a separate method
            Console.WriteLine(res);
            m1();   
        }
        public void showoutput(IAsyncResult ar)
        {
            var res = ob.EndInvoke(ar); //destroys the thread
            Console.WriteLine(res);

        }
        public void callgen()
        {
            mygendel<int> ob = swap;
            ob.Invoke(10, 20);
        }
        public void swap(int x, int y)
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }



    }
}
