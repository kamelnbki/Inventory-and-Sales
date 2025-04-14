using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lnventory_and_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            welcome.Text += Login.welcomename;
            string query = "SELECT ItemName, IsChecked FROM CheckboxValues WHERE ItemName IN ('checkBox1', 'checkBox2', 'checkBox3', 'checkBox4')";
            Controle controle = new Controle();
            controle.open(query);
            SqlDataReader reader=controle.execreader();
            while (reader.Read())
            {
                string itemName = reader["ItemName"].ToString();
                int bit = Convert.ToInt32(reader["IsChecked"]);
                bool isChecked = false;
                if (bit == 1)
                {
                    isChecked = true;
                }
                else if (bit == 0)
                {
                    isChecked = false;
                }
                switch (itemName)
                {
                    case "checkBox1":
                        permissions.deleteproduct = isChecked;
                        break;
                    case "checkBox2":
                        permissions.deletecustomer = isChecked;
                        break;
                    case "checkBox3":
                        permissions.deletesupplier = isChecked;
                        break;
                    case "checkBox4":
                        permissions.loginpermissions = isChecked;
                        break;
                }
            }
            reader.Close();
            controle.close();
        }
    
        private void Product_Click(object sender, EventArgs e)
        {
            Product_Form pro = new Product_Form();
            pro.Show();
            this.Hide();
        }

        private void Sales_and_Invoice_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void Customer_and_Supplier_Click(object sender, EventArgs e)
        {
            Customer_and_Supplier customer = new Customer_and_Supplier();
            customer.Show();
            this.Hide();
        }

        private void User_and_Permission_Click(object sender, EventArgs e)
        {
            if (Login.userrolr != "ADMINISTRATOR" & permissions.loginpermissions == false)
            {
                MessageBox.Show("لا تملك صلاحيات لدخول ادراة المستخدمين", "إشعار", MessageBoxButtons.OK);
                return;
            }
            User user = new User();  
            user.Show();
            this.Hide();
        }

        private void Reports_and_Statistics_Click(object sender, EventArgs e)
        {
            View_invoices invoices = new View_invoices();
            invoices.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            this.Hide();
        }

    }
}
