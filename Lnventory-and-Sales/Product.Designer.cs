using System.Resources;

namespace Lnventory_and_Sales
{
    partial class Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Form));
            this.new_product = new System.Windows.Forms.Button();
            this.data_product = new System.Windows.Forms.Button();
            this.delete_product = new System.Windows.Forms.Button();
            this.search_product = new System.Windows.Forms.Button();
            this.backpro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_product
            // 
            this.new_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.new_product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_product.Location = new System.Drawing.Point(48, 110);
            this.new_product.Name = "new_product";
            this.new_product.Size = new System.Drawing.Size(213, 52);
            this.new_product.TabIndex = 0;
            this.new_product.Text = "اضافة منتج جديد";
            this.new_product.UseVisualStyleBackColor = false;
            this.new_product.Click += new System.EventHandler(this.new_product_Click);
            // 
            // data_product
            // 
            this.data_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.data_product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_product.Location = new System.Drawing.Point(457, 110);
            this.data_product.Name = "data_product";
            this.data_product.Size = new System.Drawing.Size(213, 52);
            this.data_product.TabIndex = 1;
            this.data_product.Text = "تعديل على بيانات منتج";
            this.data_product.UseVisualStyleBackColor = false;
            this.data_product.Click += new System.EventHandler(this.data_product_Click);
            // 
            // delete_product
            // 
            this.delete_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.delete_product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_product.Location = new System.Drawing.Point(48, 302);
            this.delete_product.Name = "delete_product";
            this.delete_product.Size = new System.Drawing.Size(213, 52);
            this.delete_product.TabIndex = 2;
            this.delete_product.Text = "حذف منتج غير مطلوب";
            this.delete_product.UseVisualStyleBackColor = false;
            this.delete_product.Click += new System.EventHandler(this.delete_product_Click);
            // 
            // search_product
            // 
            this.search_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.search_product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_product.Location = new System.Drawing.Point(457, 302);
            this.search_product.Name = "search_product";
            this.search_product.Size = new System.Drawing.Size(213, 52);
            this.search_product.TabIndex = 3;
            this.search_product.Text = "بحث وعرض بيانات المنتج";
            this.search_product.UseVisualStyleBackColor = false;
            this.search_product.Click += new System.EventHandler(this.search_product_Click);
            // 
            // backpro
            // 
            this.backpro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backpro.BackgroundImage")));
            this.backpro.Location = new System.Drawing.Point(21, 21);
            this.backpro.Name = "backpro";
            this.backpro.Size = new System.Drawing.Size(55, 59);
            this.backpro.TabIndex = 4;
            this.backpro.UseVisualStyleBackColor = true;
            this.backpro.Click += new System.EventHandler(this.backpro_Click);
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.backpro);
            this.Controls.Add(this.search_product);
            this.Controls.Add(this.delete_product);
            this.Controls.Add(this.data_product);
            this.Controls.Add(this.new_product);
            this.DoubleBuffered = true;
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المنتجات";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Product_Form_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_product;
        private System.Windows.Forms.Button data_product;
        private System.Windows.Forms.Button delete_product;
        private System.Windows.Forms.Button search_product;
        private System.Windows.Forms.Button backpro;
    }
}