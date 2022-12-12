namespace stock_database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wishlistButton = new System.Windows.Forms.Button();
            this.ownedButton = new System.Windows.Forms.Button();
            this.availableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.availableStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToBeChecked = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tickerSymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.wishlistButton);
            this.panel1.Controls.Add(this.ownedButton);
            this.panel1.Controls.Add(this.availableLabel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 483);
            this.panel1.TabIndex = 0;
            // 
            // wishlistButton
            // 
            this.wishlistButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wishlistButton.Location = new System.Drawing.Point(553, 297);
            this.wishlistButton.Name = "wishlistButton";
            this.wishlistButton.Size = new System.Drawing.Size(99, 22);
            this.wishlistButton.TabIndex = 4;
            this.wishlistButton.Text = "Wishlist";
            this.wishlistButton.UseVisualStyleBackColor = true;
            // 
            // ownedButton
            // 
            this.ownedButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ownedButton.Location = new System.Drawing.Point(553, 112);
            this.ownedButton.Name = "ownedButton";
            this.ownedButton.Size = new System.Drawing.Size(99, 22);
            this.ownedButton.TabIndex = 3;
            this.ownedButton.Text = "Owned Stocks";
            this.ownedButton.UseVisualStyleBackColor = true;
            this.ownedButton.Click += new System.EventHandler(this.ownedButton_Click);
            // 
            // availableLabel
            // 
            this.availableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(12, 31);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(91, 15);
            this.availableLabel.TabIndex = 2;
            this.availableLabel.Text = "Available stocks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ToBeChecked,
            this.tickerSymbolDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.marketDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.availableStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // availableStockBindingSource
            // 
            this.availableStockBindingSource.DataSource = typeof(stock_database.Models.AvailableStock);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ToBeChecked
            // 
            this.ToBeChecked.HeaderText = "ToBeChecked";
            this.ToBeChecked.Name = "ToBeChecked";
            // 
            // tickerSymbolDataGridViewTextBoxColumn
            // 
            this.tickerSymbolDataGridViewTextBoxColumn.DataPropertyName = "TickerSymbol";
            this.tickerSymbolDataGridViewTextBoxColumn.HeaderText = "TickerSymbol";
            this.tickerSymbolDataGridViewTextBoxColumn.Name = "tickerSymbolDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // marketDataGridViewTextBoxColumn
            // 
            this.marketDataGridViewTextBoxColumn.DataPropertyName = "Market";
            this.marketDataGridViewTextBoxColumn.HeaderText = "Market";
            this.marketDataGridViewTextBoxColumn.Name = "marketDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 495);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label availableLabel;
        private Button ownedButton;
        private Button wishlistButton;
        private BindingSource availableStockBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn ToBeChecked;
        private DataGridViewTextBoxColumn tickerSymbolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marketDataGridViewTextBoxColumn;
    }
}