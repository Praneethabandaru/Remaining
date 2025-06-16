using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class delrealtimecls
    {
        public delegate bool myrealdel(int x);
        public void FilterMethod(int[] data,myrealdel d)
        {
            foreach (int i in data)
            {
                //if(i>30)
                if(d.Invoke(i)) //my logic is executed
                {
                    //Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
