namespace Lnventory_and_Sales
{
    partial class Supplier_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_management));
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.viewdata = new System.Windows.Forms.Button();
            this.allsupplier = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(73, 210);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(133, 35);
            this.delete.TabIndex = 0;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(334, 210);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 35);
            this.save.TabIndex = 1;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // viewdata
            // 
            this.viewdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewdata.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewdata.Location = new System.Drawing.Point(571, 210);
            this.viewdata.Name = "viewdata";
            this.viewdata.Size = new System.Drawing.Size(228, 35);
            this.viewdata.TabIndex = 2;
            this.viewdata.Text = "عرض المنتجات التي يوردها";
            this.viewdata.UseVisualStyleBackColor = false;
            this.viewdata.Click += new System.EventHandler(this.viewdata_Click);
            // 
            // allsupplier
            // 
            this.allsupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.allsupplier.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allsupplier.Location = new System.Drawing.Point(307, 297);
            this.allsupplier.Name = "allsupplier";
            this.allsupplier.Size = new System.Drawing.Size(194, 35);
            this.allsupplier.TabIndex = 3;
            this.allsupplier.Text = "عرض كل الموردين";
            this.allsupplier.UseVisualStyleBackColor = false;
            this.allsupplier.Click += new System.EventHandler(this.allsupplier_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelname.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(211, 77);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(105, 22);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "اسم المورد :";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelphone.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(207, 152);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(141, 22);
            this.labelphone.TabIndex = 6;
            this.labelphone.Text = "رقم هاتف المورد :";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(410, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(210, 29);
            this.name.TabIndex = 8;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(410, 149);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(210, 29);
            this.phone.TabIndex = 9;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(55, 59);
            this.back.TabIndex = 10;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // Supplier_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(849, 379);
            this.Controls.Add(this.back);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.allsupplier);
            this.Controls.Add(this.viewdata);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Name = "Supplier_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الموردين";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button viewdata;
        private System.Windows.Forms.Button allsupplier;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button back;
    }
}