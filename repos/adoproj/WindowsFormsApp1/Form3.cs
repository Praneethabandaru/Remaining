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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand($"select * from customers", con);
            //runs the query and stores the result in datareader object
            SqlDataReader dr = cmd.ExecuteReader();//without async -- it means synchrnously 

            while (dr.Read()) // read() will return boolean value only it returns true if records are present
            {
                comboBox1.Items.Add(dr[1]); 
            }

            con.Close();//closes the connection
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List <cust> li = new List <cust>();

            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();//creates a new connect to sql 

            SqlCommand cmd = new SqlCommand($"select * from customers where custname = '{comboBox1.Text}'", con);
            //runs the query and stores the result in datareader object
            SqlDataReader dr = cmd.ExecuteReader();//without async -- it means synchrnously 

            while (dr.Read()) // read() will return boolean value only it returns true if records are present
            {
                li.Add(new cust() { custid =dr.GetInt32(0),custname =dr.GetString(1),dob = dr.GetDateTime(2),caddress=dr.GetString(3),cphone=dr.GetString(4) });
            }
            dataGridView1.DataSource = li;
            con.Close();//closes the connection
        }
        class cust
        {
            public int custid {  get; set; }
            public string custname { get; set; }
            public DateTime dob { get; set; }
            public string caddress { get; set; }
            public string cphone { get; set; }


        }

        
    }
}
