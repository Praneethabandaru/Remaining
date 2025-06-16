using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiondemo
{
    interface geninter<T>
    {
        void swap(T a, T b);
    }
    class testinggen<T> where T : struct //class
    {

    }
    internal class GenDemo<T> :geninter<T>
    {
        public void swap(T a,T b)
        {
            T c = a;
            a = b;
            b = c;
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b); 
        }
        public void hello(T a)
        {
            Console.WriteLine(a);
        }
    }
}
