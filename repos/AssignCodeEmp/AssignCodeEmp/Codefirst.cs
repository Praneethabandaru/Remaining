using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AssignCodeEmp;

namespace AssignCodeFirst
{
    internal class Codefirst
    {
        Model1 ob = new Model1();
        Employee emp = new Employee();
        Department d = new Department();
        public void data()
        {
            try
            {
                string a;
                do
                {

                    Console.WriteLine("Enter Department id");
                    d.DeptId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter dept Name");
                    d.DeptName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Manager");
                    d.Manager = Console.ReadLine();

                    Console.WriteLine("Enter Employee id");
                    emp.Empid = Console.ReadLine();
                    Console.WriteLine("Enter Employeee name");
                    emp.EmpName = Console.ReadLine();
                    Console.WriteLine("Enter dept Id");
                    emp.DeptId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Salary");
                    emp.Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter DOB");
                    emp.Dob = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("DO YOU WANT TO CONTINUE (Y/N)");
                    a = Console.ReadLine().ToLower();
                    Console.WriteLine("Inserted Successfully");

                    ob.Departments.Add(d);
                    //int j = ob.SaveChanges();
                    //Console.WriteLine("Total number of inserted rows" + j);
                    int j = ob.SaveChanges();
                    if (j > 0)
                    {
                        Console.WriteLine("Department inserted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert department.");
                        
                        ob.Employees.Add(emp);
                        int i = ob.SaveChanges();
                        Console.WriteLine("Total number of inserted rows" + i);
                    } 

                } while (a == "y");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
                var err = ob.GetValidationErrors(); // a;ll property errors

                foreach (var item in err)
                {
                    foreach (var item1 in item.ValidationErrors)
                    {
                        Console.WriteLine(item1.ErrorMessage);
                    }
                }
                //Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void show()
        {
            foreach (var emp in ob.Employees)
            {

                Console.WriteLine($"EmpId: {emp.Empid}, Name: {emp.EmpName},Department: {emp.DeptId}, DOB: {emp.Dob},  Salary: {emp.Salary}, Bonus: {emp.DisplayWithBonus()}");
            }
        }

    }
    public static class EmployeeExtensions
    {
        public static decimal DisplayWithBonus(this Employee employees)
        {


            return employees.Salary * 0.30m;



        }
    }

}