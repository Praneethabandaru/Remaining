using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal class Personcls
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Dob {  get; set; }

        public Personcls(string Firstname,string Lastname,DateTime Dob) 
        { 
            this.Firstname=Firstname;
            this.Lastname=Lastname;
            this.Dob = Dob;
            Console.WriteLine($"Name:{Firstname} {Lastname}");
            Console.WriteLine($"Date of Birth:{Dob}");
            Birthday();
            age();

        }
        public void Birthday()
        {
            if(Dob == DateTime.Now)
            {
                Console.WriteLine($"today is my {Firstname} birthday");
            }
            else
            {
                Console.WriteLine("today is not my birthday");
            }
        }
        public void age()
        {
            if(( DateTime.Now.Year-Dob.Year ) > 18)
            {
                Console.WriteLine($"{Firstname} age is greater than 18");
            }
            else
            {
                Console.WriteLine($"{Firstname} age is less than 18");
            }
        }

    }
}
