using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace adoproj
{
    internal class DisConnectedDemo
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public void displaycustomer()
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            //con.open not required

            da = new SqlDataAdapter("Select * from customers", con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey; //it tells that like along with key,add info like which is pk 

            SqlCommandBuilder cm = new SqlCommandBuilder(da);

            da.Fill(ds, "c");//executes query and store result in ds objects
            //here ds represents record+key
            //how to display records

            Console.WriteLine(ds.Tables["c"].Rows[0][1]);

            Console.WriteLine("-----------");
            //how to display all records 


            dt = ds.Tables["c"];

            //for (int i = 0; i < ds.Tables["c"].Rows.Count; i++)
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    //Console.WriteLine(ds.Tables["c"].Rows[i][0]);
            //    //Console.WriteLine(ds.Tables["c"].Rows[i][1]);
            //    //Console.WriteLine(ds.Tables["c"].Rows[i][2]);
            //    //Console.WriteLine(ds.Tables["c"].Rows[i][3]);
            //    //Console.WriteLine(ds.Tables["c"].Rows[i][4]);
            //    //Console.WriteLine("==========="); //displays all records of database

            //    Console.WriteLine(dt.Rows[i][0]);
            //    Console.WriteLine(dt.Rows[i][1]);
            //    Console.WriteLine(dt.Rows[i][2]);
            //    Console.WriteLine(dt.Rows[i][3]);
            //    Console.WriteLine(dt.Rows[i][4]);
            //    Console.WriteLine("-------------");
            //}
        }
        public void Search()
        {
            //id
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());

            // dt.PrimaryKey = new DataColumn[] {dt.Columns[0]};
            DataRow dr = dt.Rows.Find(id); //find method needs an primary key though we have pk it is showing error for resolving this we have 2 ways one is dt.PrimaryKey need to inform 
            //and another way is if we dont know the pk add the line under sqladapter ==> da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            if (dr != null)
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine(dr[4]);

            }
            else
            {
                Console.WriteLine("record not found");
            }
        }
        public void Insert()
        {
            //datatable 
            //a code to insert record to datatable 

            DataRow dr1 = dt.NewRow();
            dr1[0] = 11;
            dr1[1] = "Bhavi";

            dt.Rows.Add(dr1);

            //(or)
             
            //dt.Rows.Add(1100, "Satish", "1-5-2000", "pune", "7894354");
            //dt.Rows.Add(1200, "Potti", "1-1-2000", "chennai", "67867676");
            //dt.Rows.Add(1300, "Mani", "1-1-2003", "hyd", "548676");

            int i = da.Update(dt); //here we are getting error bcz violation of pk so we need to add code 
            Console.WriteLine("Total rows inserted is " + i);


        }
        public void Delete()
        {
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(id);
            Console.WriteLine(dr[0]);
            Console.WriteLine(dr[1]);
            Console.WriteLine(dr[2]);
            Console.WriteLine(dr[3]);
            Console.WriteLine(dr[4]);

            dr.Delete(); //rows will be removed from datatable

            int i = da.Update(dt);
            Console.WriteLine("Total rows deleted is " + i);
        }
        public void update()
        {
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(id);
            dr[1] = "jay";

            int i = da.Update(dt);
            Console.WriteLine("Total rows updated is " + i);
        }
        public void generatexml()
        {
            //creates xml file and stores all dataset records to xml 
            ds.WriteXml("C:\\dotnetcoredemo\\mystudents.xml");
            Console.WriteLine("created");
        }
        public void generatexmlwithchanges()
        {
            //1st changes
            DataRow dr = dt.Rows.Find(100);
            dr[1] = "vijay";

            //(delete)
            DataRow dr1 = dt.Rows.Find(100);
            dr.Delete();

            //add
            dt.Rows.Add(1300, "Mani", "1-2-2003", "hyd", "897585");
            //ds.WriteXml("C:\\dotnetcoredemo\\mystudents1.xml",XmlWriteMode.WriteSchema);//default is IgnoreSchema DiffGram is difference in data 
            ds.WriteXml("C:\\dotnetcoredemo\\mystudents1.xml", XmlWriteMode.DiffGram);
            Console.WriteLine("created");
        }
        public void getchanges()
        {
            //print only modified records
            DataRow dr =dt.Rows.Find(300);
            dr[1] = "vijay";

            DataRow dr1 = dt.Rows.Find(400);
            dr1[1] = "raj";


            if (ds.HasChanges())
            {
                DataSet dstemp = ds.GetChanges();
                for(int i = 0; i < dstemp.Tables[0].Rows.Count;i++)
                {
                    Console.WriteLine(dstemp.Tables[0].Rows[i][0]);
                    Console.WriteLine(dstemp.Tables[0].Rows[i][1]);
                    Console.WriteLine(dstemp.Tables[0].Rows[i][2]);
                    Console.WriteLine(dstemp.Tables[0].Rows[i][3]);
                    Console.WriteLine(dstemp.Tables[0].Rows[i][4]);
                }
                //ds.GetChanges(); //if the record is changed
            }
            else
            {
                Console.WriteLine("record is not changed");
            } 
        }
        public void convertreadertotable()
        {
            //connected
            //disconnected
            
            //reader to datatable 
            DataTable dt1 = new DataTable();

            //how to read dta from datareader and then store in a databse
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
           
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customers", con);
            SqlDataReader dr = cmd.ExecuteReader();

            dt1.Load(dr);

            dr.Close();
            con.Close();

          for(int i = 0;i<dt1.Rows.Count;i++)
          {
                Console.WriteLine(dt1.Rows[i][0]);
                Console.WriteLine(dt1.Rows[i][1]);
                Console.WriteLine(dt1.Rows[i][2]);
                Console.WriteLine(dt1.Rows[i][3]);
                Console.WriteLine(dt1.Rows[i][4]);
            }
        }
        public void readonlytable()
        {
            //datatable to reader
            //how to make datatable only 

            DataTableReader dtr = new DataTableReader(dt);

            //dt = read/write(add,delete,update)
            //dtr= read(u can only read) 

            while (dtr.Read())
            {
                Console.WriteLine($"{dtr[0]} {dtr[1]} {dtr[2]} {dtr[3]} {dtr[4]} ");
            }

            //datareader : connection is required
            //datatablereader : connection is not required 


            //datatable : you can navigate any direction
            //datatablereader : forward only
            
        }
        public void copy()
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            //con.open not required

            da = new SqlDataAdapter("Select * from customers", con);

            da.Fill(ds, "c");//executes query and store result in ds objects
            //here ds represents record+key
            //how to display records

            dt = ds.Tables["c"];
            DataSet ds2 = new DataSet();
            ds2 = ds.Copy();

            for (int i = 0; i < ds.Tables["c"].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables["c"].Rows[i][0]);
                Console.WriteLine(ds.Tables["c"].Rows[i][1]);
                Console.WriteLine(ds.Tables["c"].Rows[i][2]);
                Console.WriteLine(ds.Tables["c"].Rows[i][3]);
                Console.WriteLine(ds.Tables["c"].Rows[i][4]);
                Console.WriteLine("==========="); //displays all records of database
            }
        }
        public void merge()
        {
            //4.Develop a code to display records from customers and orders.
            //a.Create ds1 object which stores customers details
            //b.Create ds2 object which stores orders details
            //c.Merge ds1 with ds2 using merge method and display records from both the table using ds1

            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            //con.open not required

            da = new SqlDataAdapter("Select * from customers", con);
            //da1 = new SqlDataAdapter("select * from orders", con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey; //it tells that like along with key,add info like which is pk 

            SqlCommandBuilder cm = new SqlCommandBuilder(da);

            da.Fill(ds, "c");//executes query and store result in ds objects
            //here ds represents record+key
            //how to display records

            Console.WriteLine(ds.Tables["c"].Rows[0][1]);

            Console.WriteLine("-----------");
            //how to display all records 


            dt = ds.Tables["c"];

            for (int i = 0; i < ds.Tables["c"].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables["c"].Rows[i][0]);
                Console.WriteLine(ds.Tables["c"].Rows[i][1]);
                Console.WriteLine(ds.Tables["c"].Rows[i][2]);
                Console.WriteLine(ds.Tables["c"].Rows[i][3]);
                Console.WriteLine(ds.Tables["c"].Rows[i][4]);
                Console.WriteLine("==========="); //displays all records of database
            }
        }
    }
}
