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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        BindingManagerBase bm;
        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
         
            da = new SqlDataAdapter("Select * from customers", con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey; //it tells that like along with key,add info like which is pk 

            SqlCommandBuilder cm = new SqlCommandBuilder(da);

            da.Fill(ds, "c");
            dt = ds.Tables["c"];

            textBox1.DataBindings.Add("Text", dt, "custid");
            textBox2.DataBindings.Add("Text", dt, "custName");
            textBox3.DataBindings.Add("Text", dt, "DOB");
            textBox4.DataBindings.Add("Text", dt, "cAddress");
            textBox5.DataBindings.Add("Text", dt, "cphone");

            bm = BindingContext[dt]; //BindingContext is a collection of BindingManagerBase objects, which manage the binding of controls to data sources. 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bm.Position = 0; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bm.Position += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bm.Position -= 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1; //last record position
            MessageBox.Show("Last Record Position: " + bm.Position);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            bm.Position = int.Parse(textBox6.Text);
            if (bm.Position < 0 || bm.Position >= bm.Count)
            {             
                MessageBox.Show("Invalid Position");
                return;
            }
            

        }
    }
}
