using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproj
{
    public partial class Form3 : Form
    {
        SqlCommand cmd = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update customers set custname=@cname where custid=@cid and custname=@ocname and custaddress=@ocaddress";
            try
            {
                SqlParameter p1 = new SqlParameter("@cid", SqlDbType.Int, 4, "custid");
                SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 20, "custname");
                SqlParameter p3 = new SqlParameter("@ocid", SqlDbType.Int, 4, "custid");
                p3.SourceVersion = DataRowVersion.Original;

                SqlParameter p4 = new SqlParameter("@ocname", SqlDbType.VarChar, 20, "custname");
                p4.SourceVersion = DataRowVersion.Original;

                SqlParameter p5 = new SqlParameter("@caddress", SqlDbType.VarChar, 20, "caddress");

                SqlParameter p6 = new SqlParameter("@ocaddress", SqlDbType.VarChar, 20, "caddress");


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                cmd.CommandText = query;
                da.UpdateCommand = cmd;
                da.Update(dt);
                MessageBox.Show("Data Updated Successfully");
            }
            catch (DBConcurrencyException ex)
            { 
                MessageBox.Show("Record Already modified");
            }
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            da = new SqlDataAdapter("Select * from tableA", con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;  // telling to add primary key manually by seeing table
            cmd.Connection = con;
            //SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update customers set custname=@cname where custid=@cid and ts=@ots";
            try
            {
                SqlParameter p1 = new SqlParameter("@cid", SqlDbType.Int, 4, "custid");
                SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 20, "custname");
                SqlParameter p3 = new SqlParameter("@ocid", SqlDbType.Int, 4, "custid");
                p3.SourceVersion = DataRowVersion.Original;

                SqlParameter p4 = new SqlParameter("@ots", SqlDbType.Binary, 100, "ts");
                p4.SourceVersion = DataRowVersion.Original;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.CommandText = query;
                da.UpdateCommand = cmd;
                da.Update(dt);
                MessageBox.Show("Data Updated Successfully");
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Record Already modified");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}    
