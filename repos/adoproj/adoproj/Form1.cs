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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            //con.open not required

            da = new SqlDataAdapter("Select * from customers", con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey; //it tells that like along with key,add info like which is pk 

            SqlCommandBuilder cm = new SqlCommandBuilder(da);

            da.Fill(ds, "c");//executes query and store result in ds objects
            //here ds represents record+key
            //how to display records
            dt = ds.Tables[0];

            UniqueConstraint u = new UniqueConstraint(dt.Columns[4]);
            dt.Constraints.Add(u);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            MessageBox.Show("Data Updated Successfully");

        }
    }
}
