using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lnventory_and_Sales
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name_cus.Text != "" & phone_cus.Text != "" & phone_cus.Text.Length == 10)
            {
                string query = @"insert into CUSTOMERS(CUSTOMER_NAME,PHONE) values
                (N'" + name_cus.Text + "','" + phone_cus.Text + "');";
                Controle controle = new Controle();
                controle.open(query);
                controle.executerows();
                controle.close();
                MessageBox.Show("تمت العملية بنجاح", "إشعار", MessageBoxButtons.OK);
                Sales sales = new Sales();
                sales.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("يوجد حقل فارغ او ان رقم الهاتف لايتكون من 10 ارقام", "اشعار", MessageBoxButtons.OK);
            }
        }

        private void phone_cus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                // التحقق من الطول الحالي
                if (phone_cus.Text.Length >= 10 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("يجب أن يكون رقم الهاتف 10 أرقام فقط", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                // منع أي حرف غير رقم
                e.Handled = true;
            }
        }
        private void NewCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void backsales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }
    }
}
