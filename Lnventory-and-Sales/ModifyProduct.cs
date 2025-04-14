using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lnventory_and_Sales
{
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
        }
        Controle controle;
        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            controle = new Controle();
            string query = @"select PRODUCT_ID,PRODUCT_NAME,PRICE,QUANTITY,SUPPLIER_NAME ,PRO.SUPPLIER_ID from PRODUCTS PRO
                            JOIN SUPPLIERS SU ON PRO.SUPPLIER_ID=SU.SUPPLIER_ID
                            WHERE PRO.ISDELETED=0";
            controle.open(query);
            controle.dataviw(gridproduct);
            controle.close();
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            if (productid_modify.Text ==""| name_modify.Text == "" | pricemodify.Text == "" | quantity_modify.Text == "" | supplier_modify.Text == "")
            {
                MessageBox.Show("يوجد حقل فارغ", "إشعار", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (Convert.ToDouble(productid_modify.Text) >= 0 | Convert.ToDouble(pricemodify.Text) >= 0 | Convert.ToDouble(quantity_modify.Text) >= 0 | Convert.ToDouble(supplier_modify.Text) >= 0)
                    {
                        string query = @" update PRODUCTS
                        set PRODUCT_NAME = N'" + name_modify.Text + "', PRICE = " + Convert.ToDouble(pricemodify.Text) + ", QUANTITY = " + Convert.ToInt32(quantity_modify.Text) + ", SUPPLIER_ID = " + Convert.ToInt32(supplier_modify.Text) + "\n" +
                        "where PRODUCT_ID = " + Convert.ToInt32(productid_modify.Text);
                        controle =new Controle();
                        controle.open(query);
                        controle.executerows();
                        controle.close();
                        MessageBox.Show("تمت عملية التعديل بنجاح", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Product_Form newProduct = new Product_Form();
                        newProduct.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backmodify_Click(object sender, EventArgs e)
        {
            Product_Form form = new Product_Form();
            form.Show();
            this.Hide();
        }

        private void ModifyProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;   // السماح لازرار التحكم
                return;
            }
        }
    }
}
