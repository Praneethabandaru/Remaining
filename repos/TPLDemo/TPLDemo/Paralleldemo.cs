using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLDemo
{
    internal class Paralleldemo
    {
        public void NonParallelMethod()
        {
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("TID={0}, i={1}",
                    Thread.CurrentThread.ManagedThreadId,
                    i);

                Thread.Sleep(500);
            }
        }
       public static void ParallelMethod()
        {
            Parallel.For(0, 16, i =>
            {
                Console.WriteLine("TID={0}, i={1}",
                    Thread.CurrentThread.ManagedThreadId,
                    i);


                Thread.Sleep(500);
            });
        }
        public void Demo1()
        {
            //how to create a task

            Task.Run(() =>
            {
                for(int i=0;i<5;i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
               
            });//a piece of code run independtly(Async)

            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task2 goes here");
                    Thread.Sleep(1000);
                }
            });
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task3 goes here");
                    Thread.Sleep(1000);
                }
            });
        }
        public void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1 is running");
                Thread.Sleep(1000);
            }
        }
        public void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method2 is running");
                Thread.Sleep(1000);
            }
        }
        public void Demo2()
        {
            //how to run the task using delegates

            //Task.Run() //this code immediately

            //Action a = new Action(Method1);
            //we can write action as above or below
            Action a = delegate()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method1 is running");
                    Thread.Sleep(1000);
                }
            };

            Task t1 = new Task(a); //code willl be executed when you call start method
            t1.Start();//runs the method1

            Action b = new Action(Method2);
            Task t2 = new Task(b);
            t2.Start(); //runs the method2
        }
        public void Method3(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Demo3()
        {
            //Action<int,int>
           Action<int,int> a = Method3;
           Task t1 = new Task(() => a(10, 20));
            t1.Start();//runs the method3
        }
        public int Demo4()
        {
            return 100;
        }
        public string Demo5(int x,int y)
        {
            return "the sum is :" + (x + y);
        }
        //public string Demo5(int x,int y)
        //{
        //    return "the sum is :" + (x + y);
        //}
        public void display()
        {
            //Func<int> f = new Func<int>(Demo4);
            //Task t1 = new Task<int>(fun);

            //t1.Start();
            //Console.WriteLine($"Task1 results value {task1.Result}");

            Func<int, int, string> f = new Func<int, int, string>(Demo5);
            Task<string> t1 = new Task<string>(() => f(10, 20));
            t1.Start();
            Console.WriteLine($"Task1 results value {t1.Result}");
        }
        public void demo7()
        {
            Task res = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
            });

            Task res1 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task2 goes here");
                    Thread.Sleep(1000);
                }
            });
            //res1.Wait();//other task will continue after res1 is completted 
            //Task.WaitAll(res, res1, res2);//other will cont if both res1 and res2 is completed
            //Task.WaitAny(res, res1, res2); //other task will cont either res1 or res2 is completed
            Task res2 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task3 goes here");
                    Thread.Sleep(1000);
                }
            });
           
        }
        public void demo8()
        {
            int x = 0;

            Task.Run(() =>
            {
                int a = 5;
                int b = 6;
                x = a + b;
            });
            //res.Wait();
            Console.WriteLine("the sum is" +x);
        }
        public void demo9()
        {
            //oncomplteted,continue,when
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
            }).GetAwaiter().OnCompleted(() =>
            {
                Console.WriteLine("Task1 is completed");
            });
        }
        public void demo10()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
            }).ContinueWith((t) =>
            {
                Console.WriteLine("Task1 is completed");
            });
        }
        public void Add()
        {
            Console.WriteLine("Add method is called");
        }
        public async void demo11()
        {
            var res = 0;
            await Task.Run(() =>
            {
                Add();
            });
            Console.WriteLine("Add completed");
        }
        public void CheckStatus()
        {
            //allows you to cancel the task
            CancellationTokenSource ct = new CancellationTokenSource();
            ct.CancelAfter(3000); //cancel the task after 3 sec
            Action c = delegate
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (ct.Token.IsCancellationRequested)
                        {
                            throw new TaskCanceledException();
                        }
                        //Console.WriteLine(i);
                        Thread.Sleep(1000);
                        Console.WriteLine("first task");
                    }
                }
                catch(TaskCanceledException e)
                {
                    Console.WriteLine(e.Message);
                }
            };
            Task t1 = new Task(c);
            t1.Start();

            Task.Run(() =>
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("second task");
                    if (i == 5)
                    {
                        ct.Cancel();
                    }

                    Thread.Sleep(1000);
                }
            });                                          
            // created(not yet executed yet)
            //Ran to completion : if task is successfully completed
            //a task cancel: CancelAfter(1000) + Cancel

        }


    }
}
