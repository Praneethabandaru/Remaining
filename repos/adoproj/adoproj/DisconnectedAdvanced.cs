using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoproj
{
    internal class DisconnectedAdvanced
    {
        //RowState,RowVersion,AcceptChanges,RejectChanges
        //RowState - Indicates the current status of a row in a dataTable 

        DataTable dt = new DataTable();

        public void Demo1()
        {
            dt.Columns.Add("Studentid", typeof(int));
            dt.Columns.Add("Studentname",typeof(string));

            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Raj";

            Console.WriteLine("not yet attached :" + dr.RowState); //detached
            dt.Rows.Add(dr);
            Console.WriteLine("attached :" +dr.RowState);//added

            dt.AcceptChanges();//commits all changes to datatable
            Console.WriteLine("unchanges: "+dr.RowState); //unchanged 
            dr[1] = "srinivas"; //here we are changing the student name of raj to srinivas and accepting changes by using above method but the using of acceptchanges() 
                                //atleast 1 row need to there complusory

            Console.WriteLine("older value is :"+ dr[1,DataRowVersion.Original]); //raj
            Console.WriteLine("newer value is : "+ dr[1,DataRowVersion.Current]); //srinivas

            Console.WriteLine("Record modified:" +dr.RowState); //Modified
            dr.Delete();
            Console.WriteLine("Record Removed: "+dr.RowState); //deleted 
            Console.WriteLine("------------");
            dt.AcceptChanges();
            Console.WriteLine(dr.RowState);//here it agains will go back to original state
                                           //In 2 cases it will be detacahed : 1.if none of the row is present in database 2.if none of the rows are added then it is detached

            dt.RejectChanges();//rollback all changes from table

            foreach (DataRow dr2 in dt.Rows)
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
            }
        }
        public void Demo2()
        {

            //DataView ,RowFilter and RowStateFilter , Sorting Views and Updating data through views

            //use dataview when you want to filter the records (or) when you want to search by other column

            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            SqlDataAdapter da = new SqlDataAdapter("Select * from customers", con);
            DataSet ds = new DataSet();     
            da.Fill(ds, "c");
            dt = ds.Tables["c"];

            //i want filtered version of dt 

            DataView dv = new DataView(dt);

            //show me only banglore records
            //dv.RowFilter = "caddress = 'banglore'";

            //dv.RowFilter = "custid =100 or (custid > 300 and custid < 800) ";

            //dv.RowFilter = "caddress = 'banglore' and custname ='jay'";

            //dv.RowFilter = "caddress = 'hyderabad' and custname like 'P%' "; 

            //dv.Sort = "custname DESC";

            //dt.Rows.Add(1300,"mani", "07-06-2003", "Hyderabad", "749561");
            //dt.Rows.Add(1400,"shankar", "07-06-2000", "delhi", "798174658");

            //from dataview show me only rows which is added 
            //storing the record in dataview based on state 
            dv.RowStateFilter = DataViewRowState.Added;

            dt.Rows[0][1] = "Girish";

            //dv.RowStateFilter = DataViewRowState.ModifiedCurrent;

            foreach (DataRowView item in dv) //use DataRow when you are retriving from row here we are using DataRowView which we are retriving from view
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
                Console.WriteLine("------------");
            }
            dt.AcceptChanges();//here we will get girish details 

            dv.RowStateFilter = DataViewRowState.ModifiedOriginal;//prints original record
            //dt.Rows[0].Delete();
            //dv.RowStateFilter = DataViewRowState.Deleted;
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }
        }
        public void demo3()
        {

            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            SqlDataAdapter da = new SqlDataAdapter("Select * from customers", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "c");
            dt = ds.Tables["c"];

            //i want filtered version of dt 

            DataView dv = new DataView(dt);

            //how to add records from view 

            DataRowView dd = dv.AddNew();
            dd[0] = 2000;
            dd[1] = "Amit";
            dd[2] = "2-3-1900";
            dd[3] = "Mumbai";
            dd[4] = "94933";
            dd.EndEdit(); //done with changes,now update to datatable 
            //delete a record from view and show the result in datatable 

            //dv.AllowDelete = true;
            dv.Delete(0);
            dt.AcceptChanges();

            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    Console.WriteLine(item[0]);
                    Console.WriteLine(item[1]);
                    Console.WriteLine(item[2]);
                    Console.WriteLine(item[3]);
                    Console.WriteLine(item[4]);
                    Console.WriteLine("========");
                }
            }
            catch(DeletedRowInaccessibleException e)
            {
                Console.WriteLine(e);

            }
            
        }

    }
}

