using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticdemo
{
    internal static class exten
    {
        public static int Count (this r1 obj,string str,char ch)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    count++;
                }
            }
            return count;
        }
    }
    class r1
    {

    }
    internal static class  CheckEvenCount
    {
        public static int EventCount(this b obj)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8};
            int count = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
    class b
    {

    }
}
