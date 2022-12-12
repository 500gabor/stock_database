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
            SetTableData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetListBoxData();
        }

        private void SetTableData()
        {
            ownedBindingSource1.DataSource = furaadatbazisContext.Owneds.ToList();
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
            bool used = false;
            var selectedItem = (AvailableStock)prtfolioListBox.SelectedItem;


            Owned stock = new Owned();
            stock.Id = selectedItem.Id;
            stock.TickerSymbol = selectedItem.TickerSymbol;
            foreach (var item in furaadatbazisContext.Owneds)
            {
                if (stock.TickerSymbol == item.TickerSymbol)
                {
                    used = true;
                }
            }
            furaadatbazisContext.Owneds.Add(stock);
            try
            {
                furaadatbazisContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            SetTableData();
        }
    }
}
