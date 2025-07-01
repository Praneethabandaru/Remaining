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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();//customers
        DataTable dt1 = new DataTable();//customers
        SqlDataAdapter da,da1;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show orders data in datagrid1 ,based on id selected from combobox
            DataRow[] drr =dt.Rows[0].GetChildRows("custord");

            DataTable temp = dt1.Clone();

            foreach (var item in drr)
            {
                temp.ImportRow(item);
            }
            dataGridView2.DataSource = temp; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR15\\SQLEXPRESS");
            //con.open not required

            da = new SqlDataAdapter("Select * from customers", con);
            da1 = new SqlDataAdapter("Select * from orders",con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey; //it tells that like along with key,add info like which is pk 
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            SqlCommandBuilder cm1  = new SqlCommandBuilder(da1);
            da.Fill(ds, "c");
            da1.Fill(ds, "o");

            dt =ds.Tables["c"];
            dt1 = ds.Tables["o"];

            //DataRelation drr = new DataRelation("custord", dt.Columns[0], dt1.Columns[1]);
            //ds.Relations.Add(drr);

            //how to implement cascading 

            //ds.Relations["custord"].ChildKeyConstraint.DeleteRule = Rule.Cascade;

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "custid";
            //how to apply unique constraint 
            UniqueConstraint u = new UniqueConstraint(dt.Columns[1]);
            dt.Constraints.Add(u);
            dataGridView1.DataSource = dt; 
            dataGridView2.DataSource = dt1;

        }
    }
}
