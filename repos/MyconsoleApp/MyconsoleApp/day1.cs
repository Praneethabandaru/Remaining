using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class day1
    {
        public void greatestofthree()
        {
            Console.WriteLine("enter the 1st number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2nd number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 3rd number:");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"The greatest among {a},{b} and {c} is {a}");
            }
            else if (b > c)
            {
                Console.WriteLine($"The greatest among {a},{b} and {c} is {b}");
            }
            else
            {
                Console.WriteLine($"The greatest among {a},{b} and {c} is {c}");
            }
        }
        public void empdetails()
        {
            Console.WriteLine("Enter the Employee Name: ");
            string empname = Console.ReadLine();

            Console.WriteLine("Enter the basic Salary: ");
            float sal = float.Parse(Console.ReadLine());

            Console.WriteLine($"The HRA of sal is:"+((sal)*15/100));
            Console.WriteLine($"The DA of sal is:" + ((sal) * 10 / 100));
            Console.WriteLine($"The TAX of sal is:" + ((sal) * 8 / 100));
            Console.WriteLine($"The GrossPay of {empname} with {sal} is:" +(((sal)*15/100)+((sal)*10/100)+(sal)));
        }
        public void Factorial()
        {
            Console.WriteLine("Enter the number to find out the factorial:");
             string input = Console.ReadLine();

            int number = 5; // Default value
            if (input.Length > 0) // Checking if input has characters
            {
                number = int.Parse(input);
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"Factorial of {number} is: {result}");
        }
        public void Sumof10Nums()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Negative number entered. Stopping calculation.");
                    return;
                }
                sum += num;
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
        public void Swapnums()
        {
            Console.WriteLine("Enter 1st number:");
            int a = int.Parse(Console.ReadLine());  

            Console.WriteLine("Enter 2nd number:");
            int b = int.Parse(Console.ReadLine());

            //int temp;
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine($"after swapping the 2 numbers are {a},{b}");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after swapping the 2 numbers are {a},{b}");
        }
        public void copystring()
        {
            Console.WriteLine("Enter the 1st string:");
            string a =Console.ReadLine();

            Console.WriteLine("Enter the 2nd string:");
            string b =Console.ReadLine();

            string c = string.Copy(a)+" " +string.Copy(b);
            Console.WriteLine($"The copied string from {a} and {b} is {c}");
        }
        public void divnums()
        {
            Console.WriteLine("enter the 1st number");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2nd number");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine($"the remainder is "+(a%b));
            Console.WriteLine($"the quotient is " +(a/b));
        }
        public void printnames()
        {
            Console.WriteLine("Enter the number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the String:");
            string a = Console.ReadLine();
            Console.WriteLine("---------");
            for (int i = 1; i <= b; i++)
            {
                Console.WriteLine(a);
            }
        }
    }
}
