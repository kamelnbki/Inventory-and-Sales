namespace Lnventory_and_Sales
{
    partial class Customer_and_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_and_Supplier));
            this.costomer = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this.backCU_SP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // costomer
            // 
            this.costomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.costomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costomer.Location = new System.Drawing.Point(99, 103);
            this.costomer.Name = "costomer";
            this.costomer.Size = new System.Drawing.Size(163, 53);
            this.costomer.TabIndex = 0;
            this.costomer.Text = "ادارة الزبائن";
            this.costomer.UseVisualStyleBackColor = false;
            this.costomer.Click += new System.EventHandler(this.costomer_Click);
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.supplier.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Location = new System.Drawing.Point(373, 103);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(163, 53);
            this.supplier.TabIndex = 1;
            this.supplier.Text = "ادارة الموردين";
            this.supplier.UseVisualStyleBackColor = false;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // backCU_SP
            // 
            this.backCU_SP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backCU_SP.BackgroundImage")));
            this.backCU_SP.Location = new System.Drawing.Point(12, 12);
            this.backCU_SP.Name = "backCU_SP";
            this.backCU_SP.Size = new System.Drawing.Size(49, 50);
            this.backCU_SP.TabIndex = 5;
            this.backCU_SP.UseVisualStyleBackColor = true;
            this.backCU_SP.Click += new System.EventHandler(this.backCU_SP_Click);
            // 
            // Customer_and_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 261);
            this.Controls.Add(this.backCU_SP);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.costomer);
            this.Name = "Customer_and_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الزبائن والموردين";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Customer_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button costomer;
        private System.Windows.Forms.Button supplier;
        private System.Windows.Forms.Button backCU_SP;
    }
}