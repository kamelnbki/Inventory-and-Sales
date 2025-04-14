namespace Lnventory_and_Sales
{
    partial class ModifyProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProduct));
            this.supplier_modify = new System.Windows.Forms.TextBox();
            this.quantity_modify = new System.Windows.Forms.TextBox();
            this.pricemodify = new System.Windows.Forms.TextBox();
            this.name_modify = new System.Windows.Forms.TextBox();
            this.supplierpro_modify = new System.Windows.Forms.Label();
            this.quantitypro_modify = new System.Windows.Forms.Label();
            this.pricepro_modify = new System.Windows.Forms.Label();
            this.namepro_modify = new System.Windows.Forms.Label();
            this.productid_modify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridproduct = new System.Windows.Forms.DataGridView();
            this.confirm = new System.Windows.Forms.Button();
            this.backmodify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_modify
            // 
            this.supplier_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_modify.Location = new System.Drawing.Point(297, 341);
            this.supplier_modify.Multiline = true;
            this.supplier_modify.Name = "supplier_modify";
            this.supplier_modify.Size = new System.Drawing.Size(200, 24);
            this.supplier_modify.TabIndex = 15;
            // 
            // quantity_modify
            // 
            this.quantity_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_modify.Location = new System.Drawing.Point(297, 259);
            this.quantity_modify.Multiline = true;
            this.quantity_modify.Name = "quantity_modify";
            this.quantity_modify.Size = new System.Drawing.Size(200, 24);
            this.quantity_modify.TabIndex = 14;
            // 
            // pricemodify
            // 
            this.pricemodify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricemodify.Location = new System.Drawing.Point(297, 184);
            this.pricemodify.Multiline = true;
            this.pricemodify.Name = "pricemodify";
            this.pricemodify.Size = new System.Drawing.Size(200, 24);
            this.pricemodify.TabIndex = 13;
            // 
            // name_modify
            // 
            this.name_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_modify.Location = new System.Drawing.Point(297, 112);
            this.name_modify.Multiline = true;
            this.name_modify.Name = "name_modify";
            this.name_modify.Size = new System.Drawing.Size(200, 24);
            this.name_modify.TabIndex = 12;
            // 
            // supplierpro_modify
            // 
            this.supplierpro_modify.AutoSize = true;
            this.supplierpro_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierpro_modify.Location = new System.Drawing.Point(82, 341);
            this.supplierpro_modify.Name = "supplierpro_modify";
            this.supplierpro_modify.Size = new System.Drawing.Size(149, 21);
            this.supplierpro_modify.TabIndex = 11;
            this.supplierpro_modify.Text = "معرف مورد المنتج : ";
            // 
            // quantitypro_modify
            // 
            this.quantitypro_modify.AutoSize = true;
            this.quantitypro_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitypro_modify.Location = new System.Drawing.Point(82, 256);
            this.quantitypro_modify.Name = "quantitypro_modify";
            this.quantitypro_modify.Size = new System.Drawing.Size(117, 21);
            this.quantitypro_modify.TabIndex = 10;
            this.quantitypro_modify.Text = " تغيير الكمية  : ";
            // 
            // pricepro_modify
            // 
            this.pricepro_modify.AutoSize = true;
            this.pricepro_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricepro_modify.Location = new System.Drawing.Point(82, 184);
            this.pricepro_modify.Name = "pricepro_modify";
            this.pricepro_modify.Size = new System.Drawing.Size(117, 21);
            this.pricepro_modify.TabIndex = 9;
            this.pricepro_modify.Text = "السعر الجديد : ";
            // 
            // namepro_modify
            // 
            this.namepro_modify.AutoSize = true;
            this.namepro_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namepro_modify.Location = new System.Drawing.Point(82, 112);
            this.namepro_modify.Name = "namepro_modify";
            this.namepro_modify.Size = new System.Drawing.Size(173, 21);
            this.namepro_modify.TabIndex = 8;
            this.namepro_modify.Text = " الاسم الجديد للمنتج : ";
            // 
            // productid_modify
            // 
            this.productid_modify.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid_modify.Location = new System.Drawing.Point(297, 47);
            this.productid_modify.Multiline = true;
            this.productid_modify.Name = "productid_modify";
            this.productid_modify.Size = new System.Drawing.Size(200, 24);
            this.productid_modify.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "اختر معرف المنتج : ";
            // 
            // gridproduct
            // 
            this.gridproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridproduct.BackgroundColor = System.Drawing.Color.White;
            this.gridproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridproduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridproduct.Location = new System.Drawing.Point(533, 0);
            this.gridproduct.Name = "gridproduct";
            this.gridproduct.RowHeadersWidth = 51;
            this.gridproduct.RowTemplate.Height = 26;
            this.gridproduct.Size = new System.Drawing.Size(664, 448);
            this.gridproduct.TabIndex = 18;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirm.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(136, 393);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(286, 43);
            this.confirm.TabIndex = 19;
            this.confirm.Text = "تاكيد عملية التعديل على المنتج";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // backmodify
            // 
            this.backmodify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backmodify.BackgroundImage")));
            this.backmodify.Location = new System.Drawing.Point(12, 12);
            this.backmodify.Name = "backmodify";
            this.backmodify.Size = new System.Drawing.Size(55, 59);
            this.backmodify.TabIndex = 20;
            this.backmodify.UseVisualStyleBackColor = true;
            this.backmodify.Click += new System.EventHandler(this.backmodify_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 448);
            this.Controls.Add(this.backmodify);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.gridproduct);
            this.Controls.Add(this.productid_modify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplier_modify);
            this.Controls.Add(this.quantity_modify);
            this.Controls.Add(this.pricemodify);
            this.Controls.Add(this.name_modify);
            this.Controls.Add(this.supplierpro_modify);
            this.Controls.Add(this.quantitypro_modify);
            this.Controls.Add(this.pricepro_modify);
            this.Controls.Add(this.namepro_modify);
            this.Name = "ModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل المنتج";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProduct_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supplier_modify;
        private System.Windows.Forms.TextBox quantity_modify;
        private System.Windows.Forms.TextBox pricemodify;
        private System.Windows.Forms.TextBox name_modify;
        private System.Windows.Forms.Label supplierpro_modify;
        private System.Windows.Forms.Label quantitypro_modify;
        private System.Windows.Forms.Label pricepro_modify;
        private System.Windows.Forms.Label namepro_modify;
        private System.Windows.Forms.TextBox productid_modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridproduct;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button backmodify;
    }
}