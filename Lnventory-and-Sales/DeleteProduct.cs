using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lnventory_and_Sales
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }
        Controle controle;

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            updategrid();
        }
        public void updategrid()
        {
            string query = @"select PRODUCT_ID,PRODUCT_NAME,PRICE,QUANTITY,SUPPLIER_NAME ,PRO.SUPPLIER_ID from PRODUCTS PRO
                            JOIN SUPPLIERS SU ON PRO.SUPPLIER_ID=SU.SUPPLIER_ID
                            WHERE PRO.ISDELETED=0";
            controle = new Controle();
            controle.open(query);
            controle.dataviw(dataGriddelete);
            controle.close();
        }
        private void backmodify_Click(object sender, EventArgs e)
        {
            Product_Form productForm = new Product_Form();  
            productForm.Show();
            this.Hide();
        }

        private void confirmdelete_Click(object sender, EventArgs e)
        {
            if (productid_delete.Text!=""&name_delete.Text!="")
            {
                string query = "update PRODUCTS set ISDELETED=1 WHERE PRODUCT_ID=" + productid_delete.Text + " and PRODUCT_NAME=N'" + name_delete.Text + "';";
                controle = new Controle();
                controle.open(query);
               int rowsAffected= controle.executerows();
                controle.close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("تم تنفيذ العملية بنجاح ");
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على أي صف ");
                }
                productid_delete.Text = name_delete.Text="";
                updategrid();
            }
            else
            {
                MessageBox.Show("يوجد حقل فارغ", "إشعار", MessageBoxButtons.OK);
            }
        }

        private void productid_delete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled=false;
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; 
                return;
            }
            e.Handled = true;   
        }

        private void dataGriddelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
