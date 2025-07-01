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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder s = new SqlConnectionStringBuilder();
            s.ConnectionString = "Integrated Security=true";
            s.DataSource = "WKSBAN36SUHTR15\\SQLEXPRESS"; // Server Name  
            s.InitialCatalog = "b248db"; // Database Name  
            string st = s.ConnectionString;
            SqlConnection con = new SqlConnection(st);

            con.Open();
            // Collecting user input  
            var id = textBox1.Text;
            var name = textBox2.Text;
            var dt = dateTimePicker1.Value; // Corrected: Use 'Value' property to get the selected date and time  
            var add = textBox4.Text;
            var ph = textBox5.Text;

            SqlCommand cmd = new SqlCommand($"insert into customers values({id},'{name}','{dt}','{add}','{ph}')", con);

            int r = cmd.ExecuteNonQuery(); // runs the query and stores a data reader object  

            Console.WriteLine($"Total records inserted : {r}");

            con.Close();
        }
    }
}
