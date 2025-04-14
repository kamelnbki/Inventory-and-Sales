namespace Lnventory_and_Sales
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.namepro = new System.Windows.Forms.TextBox();
            this.pricepro = new System.Windows.Forms.TextBox();
            this.quantitypro = new System.Windows.Forms.TextBox();
            this.addproduct = new System.Windows.Forms.Button();
            this.backnewpro = new System.Windows.Forms.Button();
            this.comboBoxsupplier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(128, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 24);
            this.name.TabIndex = 0;
            this.name.Text = "اسم المنتج :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(128, 157);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(73, 24);
            this.price.TabIndex = 1;
            this.price.Text = "السعر :";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(128, 240);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(81, 24);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "الكمية : ";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Location = new System.Drawing.Point(128, 325);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(110, 24);
            this.supplier.TabIndex = 3;
            this.supplier.Text = "اختر المورد :";
            // 
            // namepro
            // 
            this.namepro.Location = new System.Drawing.Point(412, 62);
            this.namepro.Multiline = true;
            this.namepro.Name = "namepro";
            this.namepro.Size = new System.Drawing.Size(200, 24);
            this.namepro.TabIndex = 4;
            // 
            // pricepro
            // 
            this.pricepro.Location = new System.Drawing.Point(412, 157);
            this.pricepro.Multiline = true;
            this.pricepro.Name = "pricepro";
            this.pricepro.Size = new System.Drawing.Size(200, 24);
            this.pricepro.TabIndex = 5;
            // 
            // quantitypro
            // 
            this.quantitypro.Location = new System.Drawing.Point(412, 243);
            this.quantitypro.Multiline = true;
            this.quantitypro.Name = "quantitypro";
            this.quantitypro.Size = new System.Drawing.Size(200, 24);
            this.quantitypro.TabIndex = 6;
            // 
            // addproduct
            // 
            this.addproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addproduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct.Location = new System.Drawing.Point(278, 386);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(184, 39);
            this.addproduct.TabIndex = 8;
            this.addproduct.Text = "اضافة : ";
            this.addproduct.UseVisualStyleBackColor = false;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // backnewpro
            // 
            this.backnewpro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backnewpro.BackgroundImage")));
            this.backnewpro.Location = new System.Drawing.Point(12, 12);
            this.backnewpro.Name = "backnewpro";
            this.backnewpro.Size = new System.Drawing.Size(55, 59);
            this.backnewpro.TabIndex = 9;
            this.backnewpro.UseVisualStyleBackColor = true;
            this.backnewpro.Click += new System.EventHandler(this.backnewpro_Click);
            // 
            // comboBoxsupplier
            // 
            this.comboBoxsupplier.FormattingEnabled = true;
            this.comboBoxsupplier.Location = new System.Drawing.Point(412, 325);
            this.comboBoxsupplier.Name = "comboBoxsupplier";
            this.comboBoxsupplier.Size = new System.Drawing.Size(200, 24);
            this.comboBoxsupplier.TabIndex = 10;
            this.comboBoxsupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxsupplier_SelectedIndexChanged);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.comboBoxsupplier);
            this.Controls.Add(this.backnewpro);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.quantitypro);
            this.Controls.Add(this.pricepro);
            this.Controls.Add(this.namepro);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منتج جديد";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewProduct_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label supplier;
        private System.Windows.Forms.TextBox namepro;
        private System.Windows.Forms.TextBox pricepro;
        private System.Windows.Forms.TextBox quantitypro;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button backnewpro;
        private System.Windows.Forms.ComboBox comboBoxsupplier;
    }
}