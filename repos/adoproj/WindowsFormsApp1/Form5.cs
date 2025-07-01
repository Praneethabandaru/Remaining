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
    public partial class Form5 : Form
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            
            
            da = new SqlDataAdapter($"Select * from customers where dob between '{dateTimePicker1.Value.Date}' and '{dateTimePicker2.Value.Date}'", con);

            da.Fill(ds, "c");//executes query and store result in ds objects
            

            dt = ds.Tables["c"];
            dataGridView1.DataSource = dt;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
