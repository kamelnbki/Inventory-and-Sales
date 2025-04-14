namespace Lnventory_and_Sales
{
    partial class NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomer));
            this.namecustomer = new System.Windows.Forms.Label();
            this.phonecustomer = new System.Windows.Forms.Label();
            this.name_cus = new System.Windows.Forms.TextBox();
            this.phone_cus = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.backsales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namecustomer
            // 
            this.namecustomer.AutoSize = true;
            this.namecustomer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namecustomer.Location = new System.Drawing.Point(79, 63);
            this.namecustomer.Name = "namecustomer";
            this.namecustomer.Size = new System.Drawing.Size(86, 28);
            this.namecustomer.TabIndex = 0;
            this.namecustomer.Text = "الاسم :";
            // 
            // phonecustomer
            // 
            this.phonecustomer.AutoSize = true;
            this.phonecustomer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonecustomer.Location = new System.Drawing.Point(79, 142);
            this.phonecustomer.Name = "phonecustomer";
            this.phonecustomer.Size = new System.Drawing.Size(126, 28);
            this.phonecustomer.TabIndex = 1;
            this.phonecustomer.Text = "رقم الهاتف :";
            // 
            // name_cus
            // 
            this.name_cus.Location = new System.Drawing.Point(262, 63);
            this.name_cus.Multiline = true;
            this.name_cus.Name = "name_cus";
            this.name_cus.Size = new System.Drawing.Size(163, 28);
            this.name_cus.TabIndex = 2;
            // 
            // phone_cus
            // 
            this.phone_cus.Location = new System.Drawing.Point(262, 142);
            this.phone_cus.Multiline = true;
            this.phone_cus.Name = "phone_cus";
            this.phone_cus.Size = new System.Drawing.Size(163, 28);
            this.phone_cus.TabIndex = 3;
            this.phone_cus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_cus_KeyPress);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(157, 223);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(184, 39);
            this.add.TabIndex = 4;
            this.add.Text = "اضافة";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // backsales
            // 
            this.backsales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backsales.BackgroundImage")));
            this.backsales.Location = new System.Drawing.Point(7, 5);
            this.backsales.Name = "backsales";
            this.backsales.Size = new System.Drawing.Size(55, 59);
            this.backsales.TabIndex = 14;
            this.backsales.UseVisualStyleBackColor = true;
            this.backsales.Click += new System.EventHandler(this.backsales_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 305);
            this.Controls.Add(this.backsales);
            this.Controls.Add(this.add);
            this.Controls.Add(this.phone_cus);
            this.Controls.Add(this.name_cus);
            this.Controls.Add(this.phonecustomer);
            this.Controls.Add(this.namecustomer);
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "زبون جديد";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namecustomer;
        private System.Windows.Forms.Label phonecustomer;
        private System.Windows.Forms.TextBox name_cus;
        private System.Windows.Forms.TextBox phone_cus;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button backsales;
    }
}