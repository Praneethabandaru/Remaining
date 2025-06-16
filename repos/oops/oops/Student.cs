using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Student
    {
        public int Studentid { get; set; }

        public string StudentName { get; set; }

        public int Marks { get; set; }

        public void GetDetails()
        {
            Console.WriteLine($"Student id{Studentid}");
            Console.WriteLine($"Student Name{StudentName}");
            Console.WriteLine($"Student Marks{Marks}");

            if(Marks > 60)
            {
                Console.WriteLine("First class");
            }
            else if(Marks< 60 && Marks >50)
            {
                Console.WriteLine("Second class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
