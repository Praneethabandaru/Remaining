using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    internal class Program
    {
        static AutoResetEvent handle = new AutoResetEvent(false);
        // static Semaphore s = new Semaphore(3, 5); //3 is the max number of threads that can access the resource at a time
        static void Main(string[] args)
        {
            //ownership : which ever application suns first, they will hold the ownership
            //only who owns the ownership,they can release the lock 

            //Mutex: is used to synchronize the threads
            //Mutex m = new Mutex(true, "hi");

            //if(!m.WaitOne(1000))
            //{
            //    Console.WriteLine("Another instance is already running");
            //}
            //else
            //{
            //    try
            //    {
            //        Run();
            //    }
            //    finally
            //    {
            //        m.ReleaseMutex();
            //    }
            //}

            //sequentailly
            demo1 ob = new demo1();
            //ob.m1();
            //ob.m2();

            //Thread : is used to create thread
            //Thread t1 = new Thread(ob.m1);//runs m1 in seperate thread
            //t1.Name = "first";
            //Thread t2 = new Thread(ob.m2);//runs in seperate thread
            //t2.Name = "second";
            //t1.Start();
            //t1.Join(); //other thread has to wait
            //t2.Start();

            //t1.Start(); //executes the method in a thread
            //t1.Abort(); //kill the thread
            //t1.Resume();//continue thread 
            //t1.Suspend();//pauses the thread
            //t1.Join(); //other thread has to wait until t1 is completed

            //Thread t3 = new Thread(ob.m3);
            //t3.Start(); 

            //Monitor: only 1 thread can access the resources 
            //other thread has to wait

            //it has enter and exit method 
            //Monitor.Enter:the lock is applied
            //Monitor.Exit: the lock is released

            //scenarios : printing 
            //locking the record in database table 
            //t1 edit the operation of t2 cannot delete the record
            //file hNDLING

            //Thread t1 = new Thread(ob.filehandling);
            //t1.Name = "first";
            //Thread t2 = new Thread(ob.filehandling);
            //t2.Name = "second";
            //t1.Start();
            //t2.Start();

            //use threadpool class for calling simple thread
            //donot use for long running method
            //.net framwork will experiemce shortage of thread

            //to access the thread pool
            //ThreadPool.QueueUserWorkItem(ob.Method1,"first pool called");

            //ThreadPool.QueueUserWorkItem(ob.Method2, "second pool called");

            //Thread tt = new Thread(execute);
            //tt.IsBackground = false; //the main tread will wait until user thread is completed its task

            //tt.IsBackground = true;//the main thread will not wait until user thread is completed its task
            //tt.Start();
            //Console.WriteLine("Main function app exited");

            //for (int i = 0; i < 20; i++)
            //{
            //    new Thread(Program.DoSomthing).Start(i);

            //}

            //new Thread(SayHello).Start("hello-1");
            //new Thread(SayHello).Start("hello-2");
            //new Thread(SayHello).Start("hello-3");
            //Thread.Sleep(2000);
            //handle.Set();
            //Thread.Sleep(2000);
            //handle.Set();
            //Thread.Sleep(2000);
            //handle.Set();

            handle.Set();
            new Thread(SayHello).Start("hello-1");
            new Thread(SayHello).Start("hello-2");
            new Thread(SayHello).Start("hello-3");
            new Thread(SayHello).Start("hello-1");
            new Thread(SayHello).Start("hello-2");
            new Thread(SayHello).Start("hello-3");
            Thread.Sleep(2000);
            handle.Reset();
            new Thread(SayHello).Start("hello-4");
            Thread.Sleep(4000);
            handle.Set();




            Console.Read();
        }
        //public static void Run()
        //{
        //    //showing this message for the first time 
        //    Console.WriteLine("Application is currently running");
        //    Console.ReadLine();
        //}

        //public static void execute()
        //{
        //    Console.WriteLine("Method-1 Entered");
        //    Console.ReadLine();
        //    Console.WriteLine("Method-1 Exited");
        //}

        //public static void DoSomthing(object id)
        //{
        //    Console.WriteLine(id + "wants to access the semaphore");
        //    s.WaitOne();
        //    Console.WriteLine(id + "has succeed to access the semaphore");
        //    Thread.Sleep(3000);
        //    Console.WriteLine(id + "is above to leave semaphore");
        //    s.Release();

        //}

        public static void SayHello(object data)
        {
            Console.WriteLine("inside say hello  " + data);
            handle.WaitOne(); //wait until the event is called
            Console.WriteLine(data);
        }

    }
}
