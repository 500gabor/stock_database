using Microsoft.EntityFrameworkCore.Infrastructure;
using stock_database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace stock_database
{
    public partial class Portfolio : Form
    {
        private FuraadatbazisContext furaadatbazisContext = new();
        public Portfolio()
        {
            InitializeComponent();
            SetListBoxData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetListBoxData();
        }

        private void SetListBoxData()
        {

            var ticker_name = from x in furaadatbazisContext.AvailableStocks
                              where x.TickerSymbol.Contains(textBox1.Text)
                              select x;
            prtfolioListBox.DataSource = ticker_name.ToList();
            prtfolioListBox.DisplayMember = "TickerSymbol";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var selectedStock = prtfolioListBox.SelectedItem;
            
        }
    }
}
