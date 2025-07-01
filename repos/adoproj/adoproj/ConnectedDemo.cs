using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace adoproj
{
    internal class ConnectedDemo
    {
        public void Displaycustomers()
        {

            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            //con.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand("select * from customers", con);
            //runs the query and stores the result in datareader object
            SqlDataReader dr = cmd.ExecuteReader();//without async -- it means synchrnously 

            while (dr.Read()) // read() will return boolean value only it returns true if records are present
            {
                //Console.WriteLine(dr[0]); //column index
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]}");
            }


            con.Close();//closes the connection
        }
        public void Displaycustomers1()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString="Integrated Security=true";
            s.DataSource="WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog="b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand("select * from customers", con);
            //runs the query and stores the result in datareader object
            SqlDataReader dr = cmd.ExecuteReader();//without async -- it means synchrnously 

            while (dr.Read()) // read() will return boolean value only it returns true if records are present
            {
                //Console.WriteLine(dr[0]); //column index
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]}");
            }

            con.Close();//closes the connection

        }
        public void InsertCustomer()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString ="Integrated Security=true";
            s.DataSource="WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog="b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection conn = new SqlConnection(st);
            conn.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand("insert into customers values (700,'sailesh','2-3-2002','chennai','989898')", conn);
            //runs the query and stores the result in datareader object
            int r = cmd.ExecuteNonQuery();

            Console.WriteLine("total records inserted is " +r);
           
            conn.Close();//closes the connection
        }
        public void InsertingCustDynamically()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; // Server Name
            s.InitialCatalog = "b248db"; // Database Name
            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);

            con.Open();
            // Collecting user input
            Console.WriteLine("Enter records to store in database");
            Console.WriteLine("Enter cust Id");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter cust Name");
            string m = Console.ReadLine();

            Console.WriteLine("Enter cust dob");
            DateTime dt = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

            Console.WriteLine("Enter cust city");
            string n = Console.ReadLine();

            Console.WriteLine("Enter cust number");
            string o = Console.ReadLine();

            SqlCommand cmd = new SqlCommand($"insert into customers values({l},'{m}','{dt}','{n}','{o}')", con);

            int r = cmd.ExecuteNonQuery();   // runs the query and stores a data reader object

            Console.WriteLine($"Total records inserted : {r}");

            con.Close();
            
        }
        public void DeleteCustomer()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection conn = new SqlConnection(st);
            conn.Open();//creates a new connect to sql 

            Console.WriteLine("Enter the Custid you want to delete:"); 
            int x = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"Delete from customers where custid={x}", conn);

            //SqlCommand cmd = new SqlCommand("Delete from customers where custid=600", conn);
            //runs the query and stores the result in datareader object
            int r = cmd.ExecuteNonQuery();

            Console.WriteLine("total records deleted is " + r);

            conn.Close();//closes the connection
        }

        public void Getbyid()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection conn = new SqlConnection(st);
            conn.Open();//creates a new connect to sql 

            Console.WriteLine("Enter the Custid you want to get the record:");
            int x = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"select * from customers where custid={x}", conn);

            //runs the query and stores the result in datareader object
            SqlDataReader r = cmd.ExecuteReader();

          while(r.Read())
          {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]} {r[3]} {r[4]}");
          }

            conn.Close();//closes the connection
        }

        public void UpdateCustomer()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection conn = new SqlConnection(st);
            conn.Open();//creates a new connect to sql 

            Console.WriteLine("Enter the Custid");
           int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cust name that you to update to :");
            string name = Console.ReadLine();

            SqlCommand cmd = new SqlCommand($"update customers set custname = '{name}' where custid ={id}", conn);
            //runs the query and stores the result in datareader object
            int r = cmd.ExecuteNonQuery();

            //Console.WriteLine("total records is " + r);

            conn.Close();//closes the connection
        }
        public void DisplayCustomersbyproc()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand("getcustomers", con);

            //SqlParameter p1 = new SqlParameter("@id", 100);
            SqlParameter p1 = new SqlParameter("@c", "m");
            SqlParameter p2 = new SqlParameter("@a", "pune");

            cmd.Parameters.Add(p1);//attaching parameter to cmd procedure 
            cmd.Parameters.Add(p2);

            cmd.CommandType = CommandType.StoredProcedure;// tabledirect-excel                                                                                                                                                                                                                                            

            //runs the query and stores the result in datareader object
            SqlDataReader dr = cmd.ExecuteReader();//without async -- it means synchrnously 

            while (dr.Read()) // read() will return boolean value only it returns true if records are present
            {
                //Console.WriteLine(dr[0]); //column index
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]}");
            }

            con.Close();//closes the connection
        }
        public void displaymultiple()
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 
            s.MultipleActiveResultSets = true;

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand("select * from customers;select * from userlogin", con);
          

            //runs the query and stores the result in datareader object
            SqlDataReader dr = cmd.ExecuteReader();//without async -- it means synchrnously 
           // SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr.Read()) // read() will return boolean value only it returns true if records are present
            {
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]}");
            }
            dr.NextResult();//runs the next query

            while (dr.Read())
            {
                int i;
                i = dr.GetInt32(2);//bultin method to typecast
                Console.WriteLine($"{dr[0]} {dr[1]} {i}"); //column index
            }
 
            con.Close();//closes the connection
        }
    }
}
