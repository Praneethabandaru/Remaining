using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MywinApp
{
    public partial class RegExDemo : Form
    {
        public RegExDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //only numbers
            var res = Regex.IsMatch(textBox1.Text, @"^[0-9]+$");
            label1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, @"^[a-zA-z]+$",RegexOptions.IgnoreCase);
            label1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dont enter space
            var res = Regex.IsMatch(textBox1.Text,"^\\S+$");
            label1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //alphabets and numbers
            var res = Regex.IsMatch(textBox1.Text, @"^[a-zA-Z0-9]+$");
            label1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //extract numbers
            var res = Regex.Match(textBox1.Text, @"\d+");
            if (res.Success)
            {
                label1.Text = res.Value;
            }
            else
            {
                MessageBox.Show("No match pattern");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = Regex.Matches(textBox1.Text, @"\d+");
            foreach (Match item in res)
            {
                if (item.Success)
                {
                    label1.Text += item.Value +"\n \n \n";
                }
                else
                {
                    MessageBox.Show("No match pattern");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //3alphabets-4 alphabets
            var res = Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]{3}-[a-zA-Z]{4}$");
            if (res)
            {
                label1.Text = "valid";
            }
            else
            {
                label1.Text = "invalid";
            }
        }

       
        private void button8_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            label1.Text = res.ToString();
        }
    }
}
