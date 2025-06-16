using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myclasslib;
using mymathlib;


namespace oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to create object
            //login ob =new login();
            //ob.uname = "mphasis";
            //ob.password= "india";
            //ob.Validate();

            //Employee e = new Employee();
            //Console.WriteLine("enter the age");
            //e.age = int.Parse(Console.ReadLine()); //set block is called 

            //Console.WriteLine(e.age); //this is not possible without get block we cant read the values 

            //Console.WriteLine("Enter the name");
            //e.name = Console.ReadLine();
            //Console.WriteLine(e.name);

            //Console.WriteLine("enter the address");
            //e.address = Console.ReadLine();
            //Console.WriteLine(e.address);

            //e.id = 100;
            //Console.WriteLine(e.id);

            //object initializer
            //ipl o = new ipl()
            //{ 
            //    teamname = "rcb", 
            //    captain = "virat",
            //    budget = 1098765
            //};
            //o.printdetail();

            //Movies m1 = new Movies()
            //{
            //    MovieId=1,
            //    MovieName="Hi Nanna",
            //    Actor="Nani",
            //    Actress="mrunal thakur"
            //};
            //m1.showdetails();

            //Movies m2 = new Movies()
            //{
            //    MovieId = 2,
            //    MovieName = "Bahubali",
            //    Actor = "Prabhas",
            //    Actress = "Anushka Sharma"
            //};
            //m2.showdetails();

            //Car c = new Car()
            //{
            //    carname = "baleno",
            //    brand = "maruthi",
            //    carcapacity = 5
            //};
            //c.displaycardetails();

            //Myteam m = new Myteam()
            //{
            //    Teamid = 1,
            //    TeamNames = new string[]{ "csk", "rcb", "srh" }
            //};
            //m.printteamdetails();

            //Student s = new Student()
            //{
            //    Studentid=1,

            //};

            //using child class object
            //we can call parent class method
            //child ob1 = new child(100);//default constructor
            ////child ob = new child();//parametrised constructor
            //ob1.hi();
            //Console.Read();

            //Class1 ob=new Class1();
            //ob.helloworld();

            //mymathcls ob1 = new mymathcls();
            //ob1.add();
            //ob1.sub();

            //staticpolydemo ob =new staticpolydemo();
            //ob.add(10,10); //int version is called
            //ob.add(20.0,20.0);//double version is called
            //ob.add(10.0f, 10.0f);//float version is called

            //MULTIPLE USER ARE USING THE OBJECT
            //THE SAME OBJECT TO PERFORM 
            //sqldb ob = new sqldb();
            //sqldb ob;
            //ob.connect();
            //ob.filter();
            //Console.WriteLine("===============");

            //ob =new oracledb();
            //ob.connect();
            //ob.filter();

            //Console.WriteLine("===========");
            //ob=new mysqldb();
            //ob.connect();
            //ob.filter();

            //mymath ob = new mymath();
            //ob.Add(100, 200);
            //ob.Sub(50,20);
            //ob.Multiply(50,20);
            //ob.Divide(50,20);

            IMath ob = new mymath();
            ob.Add(10,20);
           

            IMath1 ob1 = new mymath();
            ob1.Add(10,2);

            
        }
    }
}
