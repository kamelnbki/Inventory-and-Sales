using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lnventory_and_Sales
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        Controle controle;
        string displayText = "";
        DataGridView dataGridView;
       

        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void labelpassword_Click(object sender, EventArgs e)
        {
            password.Focus();
        }

        private void labelname_Click(object sender, EventArgs e)
        {
            username.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (username.Text!=""&password.Text!=""& combojob.SelectedItem != null)
            {
                string query = "delete  USERS where  USER_NAME=N'"+username.Text+ "'and  USER_PASSWORD=" + password.Text+" ";
                controle = new Controle();
                controle.open(query);
                int rows = controle.executerows();
                controle.close();
                if (rows > 0)
                {
                    MessageBox.Show("تم تنفيذ العملية بنجاح ");
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على أي صف ");
                }
                username.Text = password.Text = "";
                query = @"SELECT * FROM USERS ;";
                if (dataGridView != null)
                {
                    query = @"SELECT * FROM USERS ;";
                    controle.open(query);
                    controle.dataviw(dataGridView);
                    controle.close();
                }

            }
            else
                MessageBox.Show("يوجد حقل فارغ ", "إشعار", MessageBoxButtons.OK);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (username.Text != "" & password.Text != "" & combojob.SelectedItem != null)
            {
                string query = "SELECT COUNT(*) FROM USERS WHERE USER_PASSWORD = @password";

                controle = new Controle();
                controle.open(query);
                controle.command.Parameters.AddWithValue("@password", password.Text);
                int count = (int)controle.execscalar();
                controle.close();
                if (count > 0)
                {
                    MessageBox.Show("كلمة السر مستخدمة مسبقًا، الرجاء اختيار كلمة مختلفة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                query = @"INSERT INTO USERS (USER_NAME,USER_PASSWORD,USER_ROLE)  VALUES
                        ( N'" + username.Text + "','" + password.Text + "','"+combojob.Text+"');";
                controle.open(query);
                controle.executerows();
                controle.close();
                username.Text = password.Text = "";
                if (dataGridView != null)
                {
                    query = @"SELECT * FROM USERS ;";
                    controle.open(query);
                    controle.dataviw(dataGridView);
                    controle.close();
                }

                MessageBox.Show("تمت العملية بنجاح", "إشعار", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("يوجد حقل فارغ ", "إشعار", MessageBoxButtons.OK);
        }

        private void viewalluser_Click(object sender, EventArgs e)
        {
            if (dataGridView == null)
            {
                // إنشاء الغريد لأول مرة فقط
                dataGridView = new DataGridView();
                dataGridView.Dock = DockStyle.Bottom;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.BackgroundColor = Color.White;
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;

                // تكبير الفورم لعرض الغريد
                this.Height += 150;

                // إضافة الغريد إلى الواجهة
                this.Controls.Add(dataGridView);
                dataGridView.BringToFront();
               
            }
            string query = @"SELECT * FROM USERS ;";
            controle=new Controle();
            controle.open(query);
            controle.dataviw(dataGridView);
            controle.close();
        }

        private void backuser_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void viewpermissions_Click(object sender, EventArgs e)
        {
            permissions permissions = new permissions();
            permissions.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
