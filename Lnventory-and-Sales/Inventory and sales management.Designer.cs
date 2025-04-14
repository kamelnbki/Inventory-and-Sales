namespace Lnventory_and_Sales
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Product = new System.Windows.Forms.Button();
            this.Sales_and_Invoice = new System.Windows.Forms.Button();
            this.Customer_and_Supplier = new System.Windows.Forms.Button();
            this.User_and_Permission = new System.Windows.Forms.Button();
            this.Reports_and_Statistics = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(23, 107);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(268, 50);
            this.Product.TabIndex = 0;
            this.Product.Text = "ادارة المنتجات";
            this.Product.UseVisualStyleBackColor = false;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Sales_and_Invoice
            // 
            this.Sales_and_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sales_and_Invoice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_and_Invoice.Location = new System.Drawing.Point(526, 107);
            this.Sales_and_Invoice.Name = "Sales_and_Invoice";
            this.Sales_and_Invoice.Size = new System.Drawing.Size(268, 50);
            this.Sales_and_Invoice.TabIndex = 1;
            this.Sales_and_Invoice.Text = "إدارة المبيعات والفواتير";
            this.Sales_and_Invoice.UseVisualStyleBackColor = false;
            this.Sales_and_Invoice.Click += new System.EventHandler(this.Sales_and_Invoice_Click);
            // 
            // Customer_and_Supplier
            // 
            this.Customer_and_Supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Customer_and_Supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_and_Supplier.Location = new System.Drawing.Point(23, 263);
            this.Customer_and_Supplier.Name = "Customer_and_Supplier";
            this.Customer_and_Supplier.Size = new System.Drawing.Size(268, 50);
            this.Customer_and_Supplier.TabIndex = 2;
            this.Customer_and_Supplier.Text = "إدارة العملاء والموردين";
            this.Customer_and_Supplier.UseVisualStyleBackColor = false;
            this.Customer_and_Supplier.Click += new System.EventHandler(this.Customer_and_Supplier_Click);
            // 
            // User_and_Permission
            // 
            this.User_and_Permission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.User_and_Permission.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_and_Permission.Location = new System.Drawing.Point(279, 379);
            this.User_and_Permission.Name = "User_and_Permission";
            this.User_and_Permission.Size = new System.Drawing.Size(268, 50);
            this.User_and_Permission.TabIndex = 3;
            this.User_and_Permission.Text = "إدارة المستخدمين والأذونات";
            this.User_and_Permission.UseVisualStyleBackColor = false;
            this.User_and_Permission.Click += new System.EventHandler(this.User_and_Permission_Click);
            // 
            // Reports_and_Statistics
            // 
            this.Reports_and_Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Reports_and_Statistics.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_and_Statistics.Location = new System.Drawing.Point(526, 263);
            this.Reports_and_Statistics.Name = "Reports_and_Statistics";
            this.Reports_and_Statistics.Size = new System.Drawing.Size(268, 50);
            this.Reports_and_Statistics.TabIndex = 4;
            this.Reports_and_Statistics.Text = "عرض جميع الفواتير السابقة";
            this.Reports_and_Statistics.UseVisualStyleBackColor = false;
            this.Reports_and_Statistics.Click += new System.EventHandler(this.Reports_and_Statistics_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Red;
            this.logout.Font = new System.Drawing.Font("Tahoma", 12F);
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(9, 469);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(183, 41);
            this.logout.TabIndex = 5;
            this.logout.Text = "تسجيل الخروج";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Tahoma", 13F);
            this.welcome.Location = new System.Drawing.Point(73, 31);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(69, 27);
            this.welcome.TabIndex = 6;
            this.welcome.Text = "مرحبا ";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(839, 519);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Reports_and_Statistics);
            this.Controls.Add(this.User_and_Permission);
            this.Controls.Add(this.Customer_and_Supplier);
            this.Controls.Add(this.Sales_and_Invoice);
            this.Controls.Add(this.Product);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة المخزون والمبيعات";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Sales_and_Invoice;
        private System.Windows.Forms.Button Customer_and_Supplier;
        private System.Windows.Forms.Button User_and_Permission;
        private System.Windows.Forms.Button Reports_and_Statistics;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label welcome;
    }
}

