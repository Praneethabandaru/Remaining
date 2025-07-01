using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace adoproj
{
    public partial class transactiond : Form
    {
        public transactiond()
        {
            InitializeComponent();
        }

        private void transactiond_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=master;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            con.Open();//creates a new connect to sql 

            SqlCommand cmd1 = new SqlCommand("insert into tableA values (2,'jay')", con);
            SqlCommand cmd2 = new SqlCommand("insert into tableB values (2,'jay')", con);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Records Inserted Successfully");
            con.Close(); //close the connection
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlTransaction tr = null; //declare a transaction variable
            try
            {
                SqlConnection con = new SqlConnection("Integrated Security=true;database=master;server=WKSBAN36SUHTR15\\SQLEXPRESS");
                con.Open();//creates a new connect to sql 

                tr = con.BeginTransaction(); //begin a transaction
                //all the commands using (con) as a connection 

                //which al the commands will be participate  in a transaction
                //10 commands

                SqlCommand cmd1 = new SqlCommand("insert into tableA values (3,'vijay')", con);
                cmd1.Transaction = tr; //assign the transaction to the command
                cmd1.ExecuteNonQuery();
                tr.Save("hi"); //rollback from this point
                SqlCommand cmd2 = new SqlCommand("insert into tableB values (1,'vijay')", con);
                cmd2.Transaction = tr;
                //this 2 commads will participate transaction
                cmd2.ExecuteNonQuery();
                tr.Commit();
                MessageBox.Show("Records Inserted Successfully");
                con.Close(); //close the connection
            }
            catch(Exception ex) 
            {
                tr.Rollback("hi");
                tr.Commit(); //if any error occurs, rollback the transaction
                MessageBox.Show("Transaction rollbacked");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //no need to use rollback or commit 
            //it is taken care automatically by the TransactionScope class

            try
            {
                //transacton begins here  
                using (TransactionScope ts = new TransactionScope())
                {
                    using (SqlConnection con = new SqlConnection("Integrated Security=true;database=master;server=WKSBAN36SUHTR15\\SQLEXPRESS"))
                    {
                        con.Open(); //creates a new connect to sql
                        using (SqlCommand cmd1 = new SqlCommand("insert into tableA values (3,'vijay')", con))
                        {
                            cmd1.ExecuteNonQuery(); //execute the command
                        }
                        using (SqlCommand cmd2 = new SqlCommand("insert into tableB values (3,'vijay')", con))
                        {
                            cmd2.ExecuteNonQuery(); //execute the command
                        }
                        ts.Complete(); //if all the commands executed successfully, complete the transaction
                        MessageBox.Show("Transaction complteted");
                    }
                }
            } //transacation ends here
            catch (Exception ex)
            {
                MessageBox.Show("TRANSACTION ROLLBACKED");
            }
                 
        }
    }
}
