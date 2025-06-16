using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLDemo
{
    internal class Tasks
    {
        public void Display()
        {
            Console.WriteLine("Doing Something...");
            Thread.Sleep(2000);
            Console.WriteLine("Something Done!");  
        }
        public static async Task taskA()
        {
            await Task.Delay(2000);
            Console.WriteLine("Task A completed");
        }
        public static async Task taskB()
        {
            await Task.Delay(2000);
            Console.WriteLine("Task B completed");
        }
        public static async Task taskC()
        {
            await Task.Delay(2000);
            Console.WriteLine("Task C completed");
        }

        public async Task<String> GetData()
        {
            Thread.Sleep(1000);
            return "Raw Data";
        }
        public async Task<String> ProcessData()
        {
            String data = await GetData();
            return data.ToUpper();
        }
    }
}
