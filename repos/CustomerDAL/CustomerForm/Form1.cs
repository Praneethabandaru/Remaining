using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerDAL;
using System.Data.Entity.Spatial;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //BindingManagerBase bm = null;
        Class1 c = new Class1();
        //List<ProCustomer> pro;
        private List<ProCustomer> customers = new List<ProCustomer>();
        private int currentIndex = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBox1.DataSource = Enum.GetValues(typeof(CustomerType));
            customers = c.ViewCustomers();
            if (customers.Count > 0)
            {
                currentIndex = 0;
                DisplayCustomer(currentIndex);
            }

        }

        private void DisplayCustomer(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                var pro = customers[index];
                textBox1.Text = pro.CustomerId.ToString();
                textBox2.Text = pro.Name;
                textBox3.Text = pro.Email;
                textBox4.Text = pro.Mobile;
                textBox5.Text = pro.Age.ToString();
                comboBox1.SelectedItem = pro.CustomerType;
                if (pro.Location != null && pro.Location.Latitude.HasValue && pro.Location.Longitude.HasValue)
                {
                    textBox6.Text = pro.Location.Latitude.Value.ToString(CultureInfo.InvariantCulture);
                    textBox7.Text = pro.Location.Longitude.Value.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    textBox6.Text = string.Empty;
                    textBox7.Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adding cust
            // Parse latitude and longitude
            double latitude, longitude;
            DbGeography location = null;
            if (double.TryParse(textBox6.Text, out latitude) && double.TryParse(textBox7.Text, out longitude))
            {
                string point = $"POINT({longitude} {latitude})";
                location = DbGeography.PointFromText(point, 4326);
            }

            ProCustomer customer = new ProCustomer
            {
                CustomerId = int.Parse(textBox1.Text),
                Name = textBox2.Text,
                Email = textBox3.Text,
                Mobile = textBox4.Text,
                Age = int.TryParse(textBox5.Text, out int age) ? age : 0,
                CustomerType = (CustomerType)comboBox1.SelectedItem,
                RegisteredOn = dateTimePicker1.Value,
                Location = location
            };

            int result = c.Insertdata(customer);

            if (result > 0)
                MessageBox.Show("Customer added successfully!");
            else
                MessageBox.Show("Failed to add customer.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deleting cust
            int customerId;
            if (!int.TryParse(textBox1.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID.");
                return;
            }

            int result = c.Deletedata(customerId);

            MessageBox.Show(result > 0 ? "Customer Deleted Successfully" : "Failed to Delete Customer");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //search by id
            int id =int.Parse(textBox1.Text);
            var res = c.FindByID(id);
            if (res != null)
            {
                textBox1.Text = res.CustomerId.ToString();
                textBox2.Text = res.Name;
                textBox3.Text = res.Email;
                textBox4.Text = res.Mobile;
                textBox5.Text = res.Age.ToString();
                dateTimePicker1.Value =res.RegisteredOn;
                textBox5.Text = res.Location != null ? res.Location.Latitude.ToString() : "";
                textBox6.Text = res.Location != null ? res.Location.Longitude.ToString() : "";
                comboBox1.SelectedIndex = (int)res.CustomerType;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //exit 
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)ctrl).Clear();
                }
                else if (ctrl is System.Windows.Forms.ComboBox)
                {
                    ((System.Windows.Forms.ComboBox)ctrl).SelectedIndex = -1; // Reset dropdown
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now; // Reset date to current date
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(customers.Count > 0 && currentIndex < customers.Count - 1)
    {
                currentIndex++;
                DisplayCustomer(currentIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (customers.Count > 0 && currentIndex > 0)
            {
                currentIndex--;
                DisplayCustomer(currentIndex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (customers.Count > 0)
            {
                currentIndex = 0;
                DisplayCustomer(currentIndex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (customers.Count > 0)
            {
                currentIndex = customers.Count - 1;
                DisplayCustomer(currentIndex);
            }
        }

       

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("Customer Id cannot be null");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                MessageBox.Show("Name cannot be null");
            }
            if (!Regex.IsMatch(textBox2.Text, @"^[A-Za-z]+$"))
            {
                MessageBox.Show("Name cannot contain numbers and special characters");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == null)
            {
                MessageBox.Show("Customer email cannot be null");
            }
            string a = textBox3.Text;
            if (!Regex.IsMatch(a, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Enter valid Email Id");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == null)
            {
                MessageBox.Show("Mobile no. cannot be null");
            }
            if (!Regex.IsMatch(textBox4.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Mobile no. should be 10 digits long");
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select Customer type from below ComboBox");
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker1.Text) != DateTime.Now)
            {
                MessageBox.Show("RegisterOn should be today");
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker1.Text) != DateTime.Now)
            {
                MessageBox.Show("RegisterOn should be today");
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == null)
            {
                MessageBox.Show("Value must be entered");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //by clicking exit buttom we have to exit from that
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                MessageBox.Show("Exit cancelled.","Info");
            }
        }
    }
}
