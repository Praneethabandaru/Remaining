using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
    class Employe :Person
    {
        public double sal { get; set; }
    }
    class Manager :Employe
    {
        public int bonus { get; set; }
        public Manager(string Name,int age,double sal,int bonus)
        {
            this.Name=Name;
            this.age=age;
            this.sal=sal;
            this.bonus=bonus;
            Console.WriteLine($"{Name} {age} {sal} {bonus}");
            
        }
    }
}
