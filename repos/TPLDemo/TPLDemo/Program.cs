using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TPLDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //Stopwatch stopwatch = Stopwatch.StartNew();


            //stopwatch.Start();
            //Paralleldemo ob = new Paralleldemo();
            //ob.NonParallelMethod();
            //ob.Demo1();
            //ob.Demo2(); 
            //ob.Demo3();
           // ob.Demo4();
            //ob.Demo5(10, 20);
            //ob.demo9(); 
            //ob.demo10();
            //ob.demo11();    

            //Paralleldemo.ParallelMethod();
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

           /* Tasks t = new Tasks();
            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Main method continues");
                t.Display();
            });
            t1.Wait();

            Console.WriteLine("task finished in main ");
            Console.WriteLine("=======");
            Console.WriteLine("Starting all tasks...");

            var taskA = Tasks.taskA();
            var taskB = Tasks.taskB();
            var taskC = Tasks.taskC();

            Task[] tasks = { taskA, taskB, taskC };

            Task firstCompletedTask = await Task.WhenAny(tasks);

            // Determine which task finished first
            if (firstCompletedTask == taskA)
            {
                Console.WriteLine("Task A finished first!");
            }
            else if (firstCompletedTask == taskB)
            {
                Console.WriteLine("Task B finished first!");
            }
            else if (firstCompletedTask == taskC)
            {
                Console.WriteLine("Task C finished first!");
            }

            // Optionally, wait for remaining tasks to complete
            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks completed."); */


            Console.ReadLine();
        }
    }
}
