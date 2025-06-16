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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox1 textbox2
            Console.WriteLine("enter the first number");
            Console.WriteLine("enter the second number");
            int c =int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show(c.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("enter the first number");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
               label3.Text = textBox1 .Text + "is grestest";
            }
            else 
            {
                label3.Text = textBox2.Text +"is greatest";
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("please enter the first number");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
