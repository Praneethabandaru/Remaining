using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class ArrayDemo
    {
        public static void singledimension1()
        {
            int[] a = { 10, 20, 30, 50, 60 };
                      // 0   1  2   3    4
            //how do you print specific value
            Console.WriteLine(a[2]); //prints 30
            Console.WriteLine("---------");

            //how to find total no. of items in an array?
            Console.WriteLine(a.Length);
            Console.WriteLine("---------");

            //how to print all items in an array?
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------");    
            //how to sort the data
            int[] b = { 20, 3, 4, 1, 6, 78, 44 };
            Array.Sort(b);
            Console.WriteLine("---------");
            Array.Reverse(b);
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            //how to find the single dimension or multi-dimension
            Console.WriteLine("---------");
            Console.WriteLine(a.Rank);
            Console.WriteLine("---------");
        }
        public static void singledimension2()
        {
            int[] a = new int[5];//allocated memory space of 5 elements

            //foreach ==> no need of data,it is a read only loop , cant edit the data,non-index based,it will store all the values

            //for ==>    need of data,     it is read and write,   can edit the data,index-based,     it can have only part of the data

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("===========");

            foreach(var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void multidimension1()
        {
            //3 rows and 4 columns
            int[,] a =
            {
                { 10,20,30,40 },
                { 50,60,70,80 },
                { 90,100,110,120}
            };

            //how do you print specific values
            Console.WriteLine(a[1, 2]); //prints 70 index starts from 0 for both row and column

            //how to find the total no. of items
            Console.WriteLine(a.Length);

            //how to find the length of rows or length of columns?
            Console.WriteLine(a.GetLength(0)); //0 represents length of rows 

            //how to find the length of columns?
            Console.WriteLine(a.GetLength(1)); // 1 represents length of columns

            //for (int i = 0;i < a.GetLength(0);i++)
            //{
            //    for (int j = 0;j < a.GetLength(1);j++)
            //    {
            //        Console.WriteLine(a[i, j]);
            //    }
            //}
            //Console.WriteLine("===========");
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===========");
        }
        
        public static void multidimension2()
        {
            int[,] a = new int[2, 3];
            for (int i = 0; i < a.GetLength(0);i++)
            {
                for(int j = 0; j < a.GetLength(1);j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("---------");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void Jaggeddemo()
        {
            int[][] a =new int[5][];//here row size is fixed,column size is not fixed

            a[0] = new int[3] {2,5,7};//so the 1st row will have exactly 3 columns
            a[1] = new int[2] { 23,45 };//2nd row - exactly 2 columns
            a[2] = new int[5] { 12,45,6,78,89};
            a[3] = new int[0] {};
            a[4] = new int[1] {97};

            //in jagged array we are having diff sizes in cols so we can call them differently through 2 for each loops

            foreach (var item in a) //the entire 1st row is stored in item
            {
                foreach (var i in item) //from item  we are extracting the column values
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
            }
        }
        //converting value type to reference = boxing 
        //all primitive data types - value types 
        //refernce type - which does have not have size it is unlimited ex:object
        //reference type to value = unboxing
        public static void boxingdemo() 
        {
            //boxing 
            //boxing doesnot require type casting bcz object accepts anything
            int i = 10;
            object o = i;
            Console.WriteLine(o);
            ;
            //unboxing 
            //unboxing require type casting 
            int k = (int)o;
            Console.WriteLine(k);
        }
        /// <summary>
        /// this method demonstrates nullable types 
        /// it is achieved by using ? symbol
        /// </summary>
        public static void nullabledemo()
        {
            //what is the use of nullable type?
            //ans:we use nullable type to support value type
            //cant use ? for ref type
            //using nullable type we can assign null values for value datatype
            //it is achieved by using ?(question mark) symbol
            int? i = null;//without using object integer should support null means simply use ?(question mark)
            Console.WriteLine(i.HasValue);//HasValue returns bollean type true or false

            int? j = 50;
            Console.WriteLine(j.HasValue);//prints true

            if(j.HasValue)
            {
                Console.WriteLine(j.Value);//prints 50 (Value method gives the value that is stored in variable)
            }
            else
            {
                Console.WriteLine("i is null");
            }
        }

        public unsafe static void pointerdemo()
        {
            int x = 100;
            int *p = &x; 
            Console.WriteLine(*p);
        }
    }
    struct s1 //value type
    {
        public int x;
    }

    class c1 //ref type 
    {
        public int x;
    }
}
