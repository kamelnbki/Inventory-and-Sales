namespace Lnventory_and_Sales
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.invoice = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.add_cus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuantityLable = new System.Windows.Forms.Label();
            this.TotalPriceLable = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.addpro = new System.Windows.Forms.Button();
            this.Total_price = new System.Windows.Forms.TextBox();
            this.backsales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.invoice.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.Location = new System.Drawing.Point(269, 469);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(186, 43);
            this.invoice.TabIndex = 1;
            this.invoice.Text = "طباعة الفاتورة";
            this.invoice.UseVisualStyleBackColor = false;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(88, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(544, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // add_cus
            // 
            this.add_cus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add_cus.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cus.Location = new System.Drawing.Point(444, 23);
            this.add_cus.Name = "add_cus";
            this.add_cus.Size = new System.Drawing.Size(188, 42);
            this.add_cus.TabIndex = 4;
            this.add_cus.Text = "اضافة زبون جديد";
            this.add_cus.UseVisualStyleBackColor = false;
            this.add_cus.Click += new System.EventHandler(this.add_cus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(544, 165);
            this.dataGridView1.TabIndex = 5;
            // 
            // QuantityLable
            // 
            this.QuantityLable.AutoSize = true;
            this.QuantityLable.BackColor = System.Drawing.Color.White;
            this.QuantityLable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLable.Location = new System.Drawing.Point(182, 131);
            this.QuantityLable.Name = "QuantityLable";
            this.QuantityLable.Size = new System.Drawing.Size(128, 24);
            this.QuantityLable.TabIndex = 6;
            this.QuantityLable.Text = "ادخل الكمية : ";
            this.QuantityLable.Click += new System.EventHandler(this.QuantityLable_Click);
            // 
            // TotalPriceLable
            // 
            this.TotalPriceLable.AutoSize = true;
            this.TotalPriceLable.BackColor = System.Drawing.Color.White;
            this.TotalPriceLable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLable.Location = new System.Drawing.Point(182, 173);
            this.TotalPriceLable.Name = "TotalPriceLable";
            this.TotalPriceLable.Size = new System.Drawing.Size(140, 24);
            this.TotalPriceLable.TabIndex = 8;
            this.TotalPriceLable.Text = "السعر الاجمالي";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(348, 131);
            this.Quantity.Multiline = true;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(170, 24);
            this.Quantity.TabIndex = 9;
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            this.Quantity.Leave += new System.EventHandler(this.Quantity_Leave);
            // 
            // addpro
            // 
            this.addpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addpro.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpro.Location = new System.Drawing.Point(186, 233);
            this.addpro.Name = "addpro";
            this.addpro.Size = new System.Drawing.Size(332, 34);
            this.addpro.TabIndex = 11;
            this.addpro.Text = "اضافة المنتج الى الفاتورة";
            this.addpro.UseVisualStyleBackColor = false;
            this.addpro.Click += new System.EventHandler(this.addpro_Click);
            // 
            // Total_price
            // 
            this.Total_price.Enabled = false;
            this.Total_price.Location = new System.Drawing.Point(348, 177);
            this.Total_price.Multiline = true;
            this.Total_price.Name = "Total_price";
            this.Total_price.ReadOnly = true;
            this.Total_price.Size = new System.Drawing.Size(170, 24);
            this.Total_price.TabIndex = 12;
            this.Total_price.TabStop = false;
            // 
            // backsales
            // 
            this.backsales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backsales.BackgroundImage")));
            this.backsales.Location = new System.Drawing.Point(12, 12);
            this.backsales.Name = "backsales";
            this.backsales.Size = new System.Drawing.Size(49, 53);
            this.backsales.TabIndex = 14;
            this.backsales.UseVisualStyleBackColor = true;
            this.backsales.Click += new System.EventHandler(this.backsales_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 527);
            this.Controls.Add(this.backsales);
            this.Controls.Add(this.Total_price);
            this.Controls.Add(this.addpro);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.TotalPriceLable);
            this.Controls.Add(this.QuantityLable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_cus);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.invoice);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة جديدة";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sales_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button invoice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button add_cus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label QuantityLable;
        private System.Windows.Forms.Label TotalPriceLable;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button addpro;
        private System.Windows.Forms.TextBox Total_price;
        private System.Windows.Forms.Button backsales;
    }
}