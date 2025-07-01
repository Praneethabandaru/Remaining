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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; //server name
            s.InitialCatalog = "b248db"; //database name 

            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();//creates a new connect to sql 

            string uid = textBox1.Text;
            string pwd = textBox2.Text;

            SqlCommand cmd = new SqlCommand($"select count(*) from userlogin where userid='{uid}' and upassword='{pwd}'", con);
            int i = (int)cmd.ExecuteScalar(); //runs the query and stores th result in dr(datareaderobject)
            if(i==1)
            {
                MessageBox.Show("VALID USER");
            }
            else
            {
                MessageBox.Show("INVALID");
            }


            con.Close();//closes the connection
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
