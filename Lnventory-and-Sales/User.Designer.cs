namespace Lnventory_and_Sales
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.labelname = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.viewalluser = new System.Windows.Forms.Button();
            this.combojob = new System.Windows.Forms.ComboBox();
            this.labeljob = new System.Windows.Forms.Label();
            this.backuser = new System.Windows.Forms.Button();
            this.viewpermissions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelname.Location = new System.Drawing.Point(173, 52);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(162, 24);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "اسم المستخدم : ";
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelpassword.Location = new System.Drawing.Point(172, 113);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(115, 24);
            this.labelpassword.TabIndex = 1;
            this.labelpassword.Text = "كلمة السر : ";
            this.labelpassword.Click += new System.EventHandler(this.labelpassword_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Tahoma", 12F);
            this.username.Location = new System.Drawing.Point(368, 52);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(214, 32);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Tahoma", 12F);
            this.password.Location = new System.Drawing.Point(368, 113);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(214, 32);
            this.password.TabIndex = 4;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(147, 242);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 42);
            this.delete.TabIndex = 6;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Aqua;
            this.save.Font = new System.Drawing.Font("Tahoma", 12F);
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(493, 242);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 42);
            this.save.TabIndex = 7;
            this.save.Text = "حفظ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // viewalluser
            // 
            this.viewalluser.BackColor = System.Drawing.Color.Lime;
            this.viewalluser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.viewalluser.ForeColor = System.Drawing.Color.Black;
            this.viewalluser.Location = new System.Drawing.Point(447, 313);
            this.viewalluser.Name = "viewalluser";
            this.viewalluser.Size = new System.Drawing.Size(222, 42);
            this.viewalluser.TabIndex = 8;
            this.viewalluser.Text = "عرض كل المستخدمين";
            this.viewalluser.UseVisualStyleBackColor = false;
            this.viewalluser.Click += new System.EventHandler(this.viewalluser_Click);
            // 
            // combojob
            // 
            this.combojob.BackColor = System.Drawing.Color.White;
            this.combojob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combojob.FormattingEnabled = true;
            this.combojob.Items.AddRange(new object[] {
            "ADMINISTRATOR",
            "EMPLOYEE"});
            this.combojob.Location = new System.Drawing.Point(368, 180);
            this.combojob.Name = "combojob";
            this.combojob.Size = new System.Drawing.Size(214, 24);
            this.combojob.TabIndex = 9;
            // 
            // labeljob
            // 
            this.labeljob.AutoSize = true;
            this.labeljob.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labeljob.Location = new System.Drawing.Point(173, 176);
            this.labeljob.Name = "labeljob";
            this.labeljob.Size = new System.Drawing.Size(90, 24);
            this.labeljob.TabIndex = 10;
            this.labeljob.Text = "الوظيفة : ";
            // 
            // backuser
            // 
            this.backuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backuser.BackgroundImage")));
            this.backuser.Location = new System.Drawing.Point(12, 12);
            this.backuser.Name = "backuser";
            this.backuser.Size = new System.Drawing.Size(55, 59);
            this.backuser.TabIndex = 11;
            this.backuser.UseVisualStyleBackColor = true;
            this.backuser.Click += new System.EventHandler(this.backuser_Click);
            // 
            // viewpermissions
            // 
            this.viewpermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewpermissions.Font = new System.Drawing.Font("Tahoma", 12F);
            this.viewpermissions.ForeColor = System.Drawing.Color.Black;
            this.viewpermissions.Location = new System.Drawing.Point(113, 313);
            this.viewpermissions.Name = "viewpermissions";
            this.viewpermissions.Size = new System.Drawing.Size(222, 42);
            this.viewpermissions.TabIndex = 12;
            this.viewpermissions.Text = "عرض الاذونات";
            this.viewpermissions.UseVisualStyleBackColor = false;
            this.viewpermissions.Click += new System.EventHandler(this.viewpermissions_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.viewpermissions);
            this.Controls.Add(this.backuser);
            this.Controls.Add(this.labeljob);
            this.Controls.Add(this.combojob);
            this.Controls.Add(this.viewalluser);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelname);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.Load += new System.EventHandler(this.User_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button viewalluser;
        private System.Windows.Forms.ComboBox combojob;
        private System.Windows.Forms.Label labeljob;
        private System.Windows.Forms.Button backuser;
        private System.Windows.Forms.Button viewpermissions;
    }
}