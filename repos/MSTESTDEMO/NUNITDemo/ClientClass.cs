using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNITDemo
{
    internal class MyClient
    {
        IMath math;
        public MyClient(IMath m)
        {
            math = m;
        }
        public string AddClient(int a,int b)
        {
            string st = math.Add(a, b);
            return st;
        }
        public int Data
        {
            get { return math.Data; }
            set { math.Data = value; } 
        }
    }
}
