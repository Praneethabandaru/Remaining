using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (mm ob = new mm())
            {
                ob.Add();
                ob.sub();
            }//dispose is called
            Console.Read();
        }
    }
}
