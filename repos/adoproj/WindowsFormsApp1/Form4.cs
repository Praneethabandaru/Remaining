using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataSet d = new DataSet();
            d.ReadXml("C:\\hello\\customers.xml");
            dataGridView1.DataSource = d.Tables[0];
            Console.WriteLine("created");
        }
    }
}
