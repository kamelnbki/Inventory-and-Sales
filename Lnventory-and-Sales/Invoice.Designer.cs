namespace Lnventory_and_Sales
{
    partial class Invoice
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
            this.name_cusLable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.completed = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // name_cusLable
            // 
            this.name_cusLable.AutoSize = true;
            this.name_cusLable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_cusLable.Location = new System.Drawing.Point(124, 46);
            this.name_cusLable.Name = "name_cusLable";
            this.name_cusLable.Size = new System.Drawing.Size(121, 24);
            this.name_cusLable.TabIndex = 0;
            this.name_cusLable.Text = "اسم الزبون : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(430, 210);
            this.dataGridView1.TabIndex = 2;
            // 
            // completed
            // 
            this.completed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.completed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completed.Location = new System.Drawing.Point(221, 409);
            this.completed.Name = "completed";
            this.completed.Size = new System.Drawing.Size(195, 39);
            this.completed.TabIndex = 10;
            this.completed.Text = "تم";
            this.completed.UseVisualStyleBackColor = false;
            this.completed.Click += new System.EventHandler(this.completed_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(384, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 24);
            this.name.TabIndex = 11;
            this.name.Text = "name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(221, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(195, 76);
            this.dataGridView2.TabIndex = 12;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 460);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.completed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name_cusLable);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفاتورة";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Invoice_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_cusLable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button completed;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}