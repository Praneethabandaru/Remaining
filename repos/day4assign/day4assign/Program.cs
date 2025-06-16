using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the number of employees:");
            //int numEmployees = Convert.ToInt32(Console.ReadLine());

            //// Create an array to store Employee objects
            //Employee[] employees = new Employee[numEmployees];

            //// Loop to get employee details from user
            //for (int i = 0; i < numEmployees; i++)
            //{
            //    employees[i] = new Employee();

            //    Console.WriteLine($"Enter details for Employee {i + 1}:");
            //    Console.Write("Name: ");
            //    employees[i].Name = Console.ReadLine();

            //    Console.Write("Year of Joining: ");
            //    employees[i].Year = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Address: ");
            //    employees[i].Address = Console.ReadLine();
            //}

            //// Print header once
            //Console.WriteLine("\nName\tYear of joining\tAddress");

            //// Loop through employees and print details
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"{emp.Name}\t{emp.Year}\t{emp.Address}");
            //}

            //Personcls p =new Personcls( "Praneetha", "Bandaru",new DateTime(2002,02,01));

            //Console.ReadLine(); // Keeps the console window open

            //Derived ob = new Derived(100); 

            //animal a = new animal();
            //a.MakeSound();
            //Console.WriteLine("=======");
            //a=new Dog();
            //a.MakeSound();
            //Console.WriteLine("========");
            //a=new Cat();
            //a.MakeSound();

           // Manager m = new Manager("mani",22,50000,5000);

            //Vehicle v = new Vehicle();
            //v.Drive();
            //Console.WriteLine("=======");
            //v = new car();
            //v.Drive();
            //Console.WriteLine("======");
            //v=new bike();
            //v.Drive();
            //Console.WriteLine("====");

            Ishape c = new circle();
            c.CalculateArea();

            Ishape r = new rectangle();
            r.CalculateArea();
        }
    }
}
