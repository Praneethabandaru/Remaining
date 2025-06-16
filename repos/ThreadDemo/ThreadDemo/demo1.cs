using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    internal class demo1
    {
        public void m1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M1 Called :" + i);
                Thread.Sleep(1000); // 1sec
            }
        }

        public void m2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M2 Called :" + i);
                Thread.Sleep(1000); // 1sec
            }
        }
        public void m3()
        {
            Thread t4 = new Thread(m4);
            for (int i = 0; i <=30; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("staring method 2");
                    t4.Start();
                }
                else if(i == 10)
                {
                    Console.WriteLine("pausing the thread");
                    t4.Suspend();
                }
                else if(i==15)
                {
                    Console.WriteLine("continuing the thread");
                    t4.Resume();
                }
                else if (i==20)
                {
                    Console.WriteLine("killing the thread");
                    t4.Abort();
                }
                else if(i==25)
                {
                    //here the current method should kill
                    Console.WriteLine("killing the current thread");
                    Thread.CurrentThread.Abort();
                }
                else
                {
                    Console.WriteLine("M3 called");
                    Thread.Sleep(1000); // 1sec
                }
            }
        }
        public void m4()
        {
            while (true)
            {
                Console.WriteLine("M4 Called");
                Thread.Sleep(1000); // 1sec
            }
        }
        public void filehandling()
        {
            ////when you are working with resources use monitor method 
            ////only one thread can use this code
            //Monitor.Enter(this);    //HERE THIS INDICATES ONLY ONE THREAD CAN ENTER INSIDE 
            //for (int i=0;i<10;i++) //filehandling job is processing
            //{
            //    Console.WriteLine(Thread.CurrentThread.Name);//either it will print first or second
            //    Thread.Sleep(1000);
            //}
            //Monitor.Exit(this); //LOCK IS RELEASED

            //internally lock is using monitor.enter
            //simplifed version of monitor
            lock(this) //only 1 thread can enter inside
            {
               for(int i=0;i<10;i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name); //first or second
                    Thread.Sleep(1000);
                }
            }
            //Mutex m;
            //m.WaitOne(); //lock is applied 
            //m.ReleaseMutex();//lock is released
        }
        public void Method1(object ob)
        {
            for (int i = 0 ;  i < 10 ; i++)
            {
                Console.WriteLine("Method1 called");
                Thread.Sleep(1000);
            }
        }
        public void Method2(object ob)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method2 called");
                Thread.Sleep(1000);
            }
        }
        public void execute()
        {

        }
    }
}
