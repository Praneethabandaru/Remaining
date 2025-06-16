using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2_assign
{
    internal class arrayassign
    {
        public static void commonvalue()
        {
            int[] a = { 45, 78, 45, 34, 65, 89 };
            int[] b = { 78, 4, 8, 9, 65, 3, 7, 34 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }
        public static void sumoffirstcol()
        {
            int[,] a =
            {
                {1,2,3},
                {4,5,6},
                {7,1,2}
            };
            int sum = 0;
            for(int i=0;i<a.GetLength(1);i++)
            {
                sum = sum + a[i,0];
            }
            Console.WriteLine(sum);
        }
        public static void GetData()
        {
            Object[] myObjects = new Object[5];
            myObjects[0] = "hello";
            myObjects[1] = 123;
            myObjects[2] = 123.4;
            myObjects[3] = null;
            myObjects[4] = "Mphasis";

            for (int i = 0; i < myObjects.Length; i++)
            {
                if (myObjects[i] is string str)
                {
                    Console.WriteLine(str);
                }
            }
        }
        public static void countries()
        {
            String[] st = {"Srilanka","Singapore","India","Swedan","Canada"};
            foreach (String s in st)
            {
                if((s.Length) > 7 && s.StartsWith("S"))
                {
                    Console.WriteLine(s.ToUpper());
                }
            }
        }
        public static void evenodd()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int evencount = 0;
            int oddcount = 0;
            for(int i = 0;i < a.Length;i++)
            {
                if (a[i]%2==0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }
            }
            Console.WriteLine("the even count is:"+evencount);
            Console.WriteLine("The odd count is:"+oddcount);
        }
        public static void duplicate()
        {
            int[] a = { 1, 2, 1, 3, 4, 4};
            for(int i = 0; i < a.Length;i++)
            { 
                for(int j = i+1;j<a.Length;j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
        }
        public static void mergetwoarrays()
        {
            int[] a = {1,2,3,4,5,6,7};
            int[] b = { 8,9,1,2,45,78};
            int[] c = new int[a.Length+b.Length];
            Array.Copy(a,c,a.Length);
            Array.Copy(b,0,c,a.Length,b.Length);

            Console.WriteLine("Merged Array: " +string.Join(",",c));
        }

    }
}
