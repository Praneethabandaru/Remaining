using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticdemo
{
    public interface IPerson
    {
        string GetDetails();
    }

    public partial class Employee : IPerson
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string department, double salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }

    public partial class Employee
    {
        public virtual string GetDetails()
        {
            return $"Employee: {Name}, Department: {Department}, Salary: {Salary:C}";
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager(string name, string department, double salary, int teamSize) : base(name, department, salary)
        {
            TeamSize = teamSize;
        }
        public override string GetDetails()
        {
            return $"Manager: {Name}, Department: {Department}, Salary: {Salary:C}, Team Size: {TeamSize}";
        }
    }
}
