using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Lnventory_and_Sales
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }
        string displayText1 = "";
        int value1 = 0;
        private void addproduct_Click(object sender, EventArgs e)
        {
            if (namepro.Text == "" | pricepro.Text == "" | quantitypro.Text == "" | comboBoxsupplier.Text == null)
            {
                MessageBox.Show( "يوجد حقل فارغ", "إشعار", MessageBoxButtons.OK);
            }
            else
            {
                if (Convert.ToDouble(pricepro.Text) >= 0 | Convert.ToDouble(quantitypro.Text) >= 0 )
                {
                    Controle controle = new Controle();
                    string query = @"INSERT INTO PRODUCTS ( PRODUCT_NAME, PRICE, QUANTITY, SUPPLIER_ID,ISDELETED) VALUES
                        ( N'" + namepro.Text + "'," + Convert.ToDouble(pricepro.Text) + " , " + Convert.ToInt32(quantitypro.Text) + " ," + value1 + "," + 0 + ");";
                    controle.open(query);
                    controle.executerows();
                    controle.close();
                    MessageBox.Show("تمت العملية بنجاح", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Product_Form newProduct = new Product_Form();
                    newProduct.Show();
                }
            }
        }

        private void backnewpro_Click(object sender, EventArgs e)
        {
            Product_Form form = new Product_Form(); 
            form.Show();
            this.Hide();
        }

        private void NewProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxsupplier.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBoxsupplier.SelectedItem;
                displayText1 = row["SUPPLIER_NAME"].ToString();
                value1 = Convert.ToInt32(row["SUPPLIER_ID"]);
            }
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string query = "SELECT SUPPLIER_ID, SUPPLIER_NAME FROM SUPPLIERS\r\nwhere ISDELETED=0";
            controle.open(query);
            controle.dataviw(null, comboBoxsupplier, "SUPPLIER_NAME", "SUPPLIER_ID");
            controle.close();
        }
    }
}
