using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptiondemo
{
    internal class indexoutofrangedemo
    {
        public void demo1()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(numbers[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void demo2()
        {
            //OverflowException exception
            try
            {
                Console.WriteLine("Enter Number:");
                int a = int.Parse(Console.ReadLine());
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void demo3()
        {
            //3. Develop a code to handle IndexOutOfRangeException , FormatException and OverflowException in a single method
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[6]);
                Console.WriteLine("Enter Number:");
                int a = int.Parse(Console.ReadLine());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void revstr()
        {
            Console.WriteLine("enter string:");
            string a =Console.ReadLine();
            for(int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
        public void demo4()
        {
            string str = "praneetha";
            char ch = 'a';
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void demo5()
        {
            string s = "Bandaru Praneetha";
            string[] arr = s.Split(' ');
            string firstName = arr[0];
            string lastName = arr[1];
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);




        }
    }
}
