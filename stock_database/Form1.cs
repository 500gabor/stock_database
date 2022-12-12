using stock_database.Models;
using System.Collections.Generic;

namespace stock_database
{
    public partial class Form1 : Form
    {
        private FuraadatbazisContext adatbazisContext = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sure?", "Closing the program", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            availableStockBindingSource.DataSource = adatbazisContext.AvailableStocks.ToList();
            BindDates();
        }

        private void ownedButton_Click(object sender, EventArgs e)
        {
            var portfolioForm = new Portfolio();
            portfolioForm.Show();
        }

        private void BindDates()
        {
            var combobox = (DataGridViewComboBoxColumn)dataGridView1.Columns["ToBeChecked"];
            List<String> timestamps = new();
            timestamps.Add("year+");
            timestamps.Add("Months");
            timestamps.Add("Weeks");
            timestamps.Add("Days");
            combobox.DataSource = timestamps;
        }
    }
}