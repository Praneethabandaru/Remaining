using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MywinApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1 .Text == "admin" && textBox2.Text == "india")
            {
                MyNotepad ob = new MyNotepad();
                ob.Show();///modeless dialog box
                //ob.ShowDialog(); //act as a model dialogbox
            }
            else
            {
               var a = MessageBox.Show("hello","invalid",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
                MessageBox.Show(a.ToString());
            }
        }
    }
}
