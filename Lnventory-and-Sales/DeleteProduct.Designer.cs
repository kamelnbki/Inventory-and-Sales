namespace Lnventory_and_Sales
{
    partial class DeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProduct));
            this.confirmdelete = new System.Windows.Forms.Button();
            this.productid_delete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_delete = new System.Windows.Forms.TextBox();
            this.namepro_delete = new System.Windows.Forms.Label();
            this.dataGriddelete = new System.Windows.Forms.DataGridView();
            this.backmodify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddelete)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmdelete
            // 
            this.confirmdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmdelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmdelete.Location = new System.Drawing.Point(296, 174);
            this.confirmdelete.Name = "confirmdelete";
            this.confirmdelete.Size = new System.Drawing.Size(198, 43);
            this.confirmdelete.TabIndex = 32;
            this.confirmdelete.Text = "تاكيد عملية الحذف";
            this.confirmdelete.UseVisualStyleBackColor = false;
            this.confirmdelete.Click += new System.EventHandler(this.confirmdelete_Click);
            // 
            // productid_delete
            // 
            this.productid_delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid_delete.Location = new System.Drawing.Point(393, 49);
            this.productid_delete.Multiline = true;
            this.productid_delete.Name = "productid_delete";
            this.productid_delete.Size = new System.Drawing.Size(200, 24);
            this.productid_delete.TabIndex = 30;
            this.productid_delete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productid_delete_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "اختر معرف المنتج : ";
            // 
            // name_delete
            // 
            this.name_delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_delete.Location = new System.Drawing.Point(393, 114);
            this.name_delete.Multiline = true;
            this.name_delete.Name = "name_delete";
            this.name_delete.Size = new System.Drawing.Size(200, 24);
            this.name_delete.TabIndex = 25;
            // 
            // namepro_delete
            // 
            this.namepro_delete.AutoSize = true;
            this.namepro_delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namepro_delete.Location = new System.Drawing.Point(178, 114);
            this.namepro_delete.Name = "namepro_delete";
            this.namepro_delete.Size = new System.Drawing.Size(147, 21);
            this.namepro_delete.TabIndex = 21;
            this.namepro_delete.Text = "ادخل اسم المنتج : ";
            // 
            // dataGriddelete
            // 
            this.dataGriddelete.BackgroundColor = System.Drawing.Color.White;
            this.dataGriddelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriddelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGriddelete.Location = new System.Drawing.Point(0, 245);
            this.dataGriddelete.Name = "dataGriddelete";
            this.dataGriddelete.RowHeadersWidth = 51;
            this.dataGriddelete.RowTemplate.Height = 26;
            this.dataGriddelete.Size = new System.Drawing.Size(780, 204);
            this.dataGriddelete.TabIndex = 34;
            this.dataGriddelete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriddelete_CellContentClick);
            // 
            // backmodify
            // 
            this.backmodify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backmodify.BackgroundImage")));
            this.backmodify.Location = new System.Drawing.Point(6, 12);
            this.backmodify.Name = "backmodify";
            this.backmodify.Size = new System.Drawing.Size(55, 58);
            this.backmodify.TabIndex = 33;
            this.backmodify.UseVisualStyleBackColor = true;
            this.backmodify.Click += new System.EventHandler(this.backmodify_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 449);
            this.Controls.Add(this.dataGriddelete);
            this.Controls.Add(this.backmodify);
            this.Controls.Add(this.confirmdelete);
            this.Controls.Add(this.productid_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_delete);
            this.Controls.Add(this.namepro_delete);
            this.Name = "DeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف المنتجات";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteProduct_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backmodify;
        private System.Windows.Forms.Button confirmdelete;
        private System.Windows.Forms.TextBox productid_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_delete;
        private System.Windows.Forms.Label namepro_delete;
        private System.Windows.Forms.DataGridView dataGriddelete;
    }
}