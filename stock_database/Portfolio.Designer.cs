namespace stock_database
{
    partial class Portfolio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prtfolioListBox = new System.Windows.Forms.ListBox();
            this.availableStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ownedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portfolioLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.prtfolioListBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.portfolioLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 486);
            this.panel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(382, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prtfolioListBox
            // 
            this.prtfolioListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prtfolioListBox.DataSource = this.availableStockBindingSource;
            this.prtfolioListBox.FormattingEnabled = true;
            this.prtfolioListBox.ItemHeight = 15;
            this.prtfolioListBox.Location = new System.Drawing.Point(474, 27);
            this.prtfolioListBox.Name = "prtfolioListBox";
            this.prtfolioListBox.Size = new System.Drawing.Size(120, 424);
            this.prtfolioListBox.TabIndex = 1;
            // 
            // availableStockBindingSource
            // 
            this.availableStockBindingSource.DataSource = typeof(stock_database.Models.AvailableStock);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.ownedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(321, 424);
            this.dataGridView1.TabIndex = 1;
            // 
            // portfolioLabel
            // 
            this.portfolioLabel.AutoSize = true;
            this.portfolioLabel.Location = new System.Drawing.Point(12, 9);
            this.portfolioLabel.Name = "portfolioLabel";
            this.portfolioLabel.Size = new System.Drawing.Size(80, 15);
            this.portfolioLabel.TabIndex = 0;
            this.portfolioLabel.Text = "Your Portfolio";
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 498);
            this.Controls.Add(this.panel1);
            this.Name = "Portfolio";
            this.Text = "Portfolio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label portfolioLabel;
        private DataGridView dataGridView1;
        private BindingSource ownedBindingSource;
        private DataGridViewTextBoxColumn tickerSymbolDataGridViewTextBoxColumn;
        private ListBox prtfolioListBox;
        private BindingSource availableStockBindingSource;
        private TextBox textBox1;
        private Button addButton;
    }
}