using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lnventory_and_Sales
{
    public partial class searchProduct : Form
    {
        public searchProduct()
        {
            InitializeComponent();
        }
        Controle controle;
        private void backmodify_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form(); 
            product_Form.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (name_search.Text != "")
            {


                string query = "SELECT COUNT(*) FROM PRODUCTS WHERE  PRODUCT_NAME = N'" + name_search.Text + "' ";
                controle = new Controle();
                controle.open(query);
                object scalar = controle.execscalar();
                controle.close();
                int bitValueResult = (scalar != null) ? Convert.ToInt32(scalar) : -1;
                if (bitValueResult == 0)
                {
                    MessageBox.Show("المنتج غير موجود", "إشعار", MessageBoxButtons.OK);
                }
                else if (bitValueResult >= 1)
                {
                    query = @"select * from PRODUCTS  WHERE  PRODUCT_NAME = N'" + name_search.Text + "'  ";
                    controle = new Controle();
                    controle.open(query);
                    controle.dataviw(dataGridsearch);
                    controle.close();
                }

            }
            else
                MessageBox.Show("يوجد حقل فارغ", "إشعار", MessageBoxButtons.OK);
        }
        public void updgrid()
        {
            string query = @"select * from PRODUCTS ";
            controle = new Controle();
            controle.open(query);
            controle.dataviw(dataGridsearch);
            controle.close();
        }

        private void dataGridsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dataGridsearch.Columns[e.ColumnIndex].Name == "ISDELETED" && e.RowIndex >= 0)
                {

                    if (dataGridsearch[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell checkBoxCell)
                    {
                        bool isChecked = (bool)checkBoxCell.Value;

                        int productId = Convert.ToInt32(dataGridsearch.Rows[e.RowIndex].Cells["PRODUCT_ID"].Value);


                        string query = "SELECT ISDELETED FROM PRODUCTS WHERE PRODUCT_ID = " + productId + "";
                        controle = new Controle();
                        controle.open(query);
                        object scalar= controle.execscalar();
                        controle.close();
                        int bitValueResult = (scalar != null) ? Convert.ToInt32(scalar) : -1;
                        bool value = false;
                        if (bitValueResult == 0)
                        {
                            value = false;
                        }
                        else if (bitValueResult == 1)
                        {
                            value = true;
                        }
                        DialogResult result;
                        if (value == false)
                        {
                            result = MessageBox.Show("لا يمكن حذف المنتجات هنا، بل استرجاعها فقط. لحذفها، انتقل إلى واجهة الحذف.", "إشعار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                if (Login.userrolr != "ADMINISTRATOR" & permissions.deleteproduct==false)
                                {
                                    MessageBox.Show("لا تملك صلاحيات للدخول ", "إشعار", MessageBoxButtons.OK);
                                    updgrid();
                                    return;
                                }
                                DeleteProduct deleteProduct = new DeleteProduct();
                                deleteProduct.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            result = MessageBox.Show("هل تريد حقًا إرجاع المنتج؟", "إشعار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                query = @"update PRODUCTS
                                set ISDELETED = 0 WHERE PRODUCT_ID = " + productId + "";
                                controle.open(query);
                                controle.executerows();
                                controle.close();
                                MessageBox.Show("لقد تم إرجاع المنتج ويمكنك الآن تعديله.", "إشعار", MessageBoxButtons.OK);
                            }
                        }

                    }
                }
                updgrid();
            }
            catch (Exception )
            {
                MessageBox.Show($"أدخل اسم المنتج للبحث", "إشعار", MessageBoxButtons.OK);
            }
        }

        private void searchProduct_Load(object sender, EventArgs e)
        {
            updgrid();
        }

        private void viewall_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM PRODUCTS";
            controle = new Controle();
            controle.open(query);
            controle.dataviw(dataGridsearch);
            controle.close();
        }

        private void searchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
