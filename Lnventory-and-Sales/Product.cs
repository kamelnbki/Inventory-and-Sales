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
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
        }

        private void new_product_Click(object sender, EventArgs e)
        {

            NewProduct newCustomer = new NewProduct();
            newCustomer.Show();
            this.Hide();
        }

        private void data_product_Click(object sender, EventArgs e)
        {
            ModifyProduct modify = new ModifyProduct();
            modify.Show();
            this.Hide();
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            if (Login.userrolr != "ADMINISTRATOR" & permissions.deleteproduct==false)
            {
                MessageBox.Show("لا تملك صلاحيات للدخول ", "إشعار", MessageBoxButtons.OK);
                return;
            }
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.Show();
            this.Hide();
        }
        private void search_product_Click(object sender, EventArgs e)
        {
            searchProduct search=new searchProduct();
            search.Show();
            this.Hide();
        }
        private void backpro_Click(object sender, EventArgs e)
        {
           Form1 form = new Form1();
           form.Show();
           this.Hide();
        }
        private void Product_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
