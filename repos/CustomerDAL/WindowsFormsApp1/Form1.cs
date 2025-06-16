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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Model1Container mc = new Model1Container();
        private void button1_Click(object sender, EventArgs e)
        {
            string columnName = textBox1.Text.Trim();  // Column to filter
            string operatorSymbol = textBox2.Text.Trim(); // Operator (=, <, >, etc.)
            string value = textBox3.Text.Trim();  // Value to search
            string orderBy = comboBox3.SelectedItem.ToString(); // Sorting order (Asc/Desc)

            // Validate input
            if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(operatorSymbol) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            // **Replace this part** with the new logic
            var rawData = mc.ProCustomers.ToList(); // Fetch all data from DB first

            // Apply the filtering logic **in-memory** after retrieving the data
            var filteredData = rawData.Where(c =>
            {
                var columnValue = typeof(ProCustomer).GetProperty(columnName)?.GetValue(c)?.ToString();

                if (string.IsNullOrEmpty(columnValue)) return false;

                double numericValue;
                if (double.TryParse(columnValue, out numericValue))
                {
                    switch (operatorSymbol)
                    {
                        case "=": return numericValue == Convert.ToDouble(value);
                        case ">": return numericValue > Convert.ToDouble(value);
                        case "<": return numericValue < Convert.ToDouble(value);
                    }
                }
                return false;
            }).ToList();

            // Apply sorting after filtering
            filteredData = orderBy == "ASC"
                ? filteredData.OrderBy(c => typeof(ProCustomer).GetProperty(columnName)?.GetValue(c)).ToList()
                : filteredData.OrderByDescending(c => typeof(ProCustomer).GetProperty(columnName)?.GetValue(c)).ToList();

            // Bind results to DataGridView
            dataGridView1.DataSource = filteredData;
        }
    }
}
