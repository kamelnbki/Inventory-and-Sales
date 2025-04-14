namespace Lnventory_and_Sales
{
    partial class Customer_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_management));
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.allcustomar = new System.Windows.Forms.Button();
            this.viewdata = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(368, 146);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(210, 29);
            this.phone.TabIndex = 20;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(368, 71);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(210, 29);
            this.name.TabIndex = 19;
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(165, 149);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(146, 22);
            this.labelphone.TabIndex = 17;
            this.labelphone.Text = "رقم هاتف الزبون  :";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(169, 74);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(110, 22);
            this.labelname.TabIndex = 16;
            this.labelname.Text = "اسم الزبون  :";
            // 
            // allcustomar
            // 
            this.allcustomar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.allcustomar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allcustomar.Location = new System.Drawing.Point(291, 302);
            this.allcustomar.Name = "allcustomar";
            this.allcustomar.Size = new System.Drawing.Size(163, 35);
            this.allcustomar.TabIndex = 14;
            this.allcustomar.Text = "عرض كل الزبائن";
            this.allcustomar.UseVisualStyleBackColor = false;
            this.allcustomar.Click += new System.EventHandler(this.allcustomar_Click);
            // 
            // viewdata
            // 
            this.viewdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewdata.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdata.Location = new System.Drawing.Point(483, 215);
            this.viewdata.Name = "viewdata";
            this.viewdata.Size = new System.Drawing.Size(324, 35);
            this.viewdata.TabIndex = 13;
            this.viewdata.Text = "عرض جميع المنتجات التي اشتراها";
            this.viewdata.UseVisualStyleBackColor = false;
            this.viewdata.Click += new System.EventHandler(this.viewdata_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(291, 215);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(163, 35);
            this.save.TabIndex = 12;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(43, 215);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(163, 35);
            this.delete.TabIndex = 11;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(3, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(55, 59);
            this.back.TabIndex = 21;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Customer_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(822, 393);
            this.Controls.Add(this.back);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.allcustomar);
            this.Controls.Add(this.viewdata);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Name = "Customer_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الزبائن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button allcustomar;
        private System.Windows.Forms.Button viewdata;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
    }
}