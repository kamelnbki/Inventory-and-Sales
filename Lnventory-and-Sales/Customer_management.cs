using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lnventory_and_Sales
{
    public partial class Customer_management : Form
    {
        public Customer_management()
        {
            InitializeComponent();
        }
        Controle controle;
        DataGridView dataGridView;
        private void delete_Click(object sender, EventArgs e)
        {
            if (Login.userrolr != "ADMINISTRATOR" & permissions.deletecustomer == false)
            {
                MessageBox.Show("لا تملك صلاحيات للدخول ", "إشعار", MessageBoxButtons.OK);
                return;
            }
            if (name.Text != "" & phone.Text != "" & phone.Text.Length==10)
            {
                string query = "SELECT COUNT(*) FROM CUSTOMERS WHERE  CUSTOMER_NAME = N'" + name.Text + "' and  PHONE = '" + phone.Text + "' and ISDELETED=0";
                controle = new Controle();
                controle.open(query);
                object scalar = controle.execscalar();
                controle.close();
                int bitValueResult = (scalar != null) ? Convert.ToInt32(scalar) : -1;
                bool value = false;
                if (bitValueResult == 0)
                {
                    value = false;
                }
                else if (bitValueResult >= 1)
                {
                    value = true;
                }
                if (value)
                {
                    DialogResult result= MessageBox.Show("هل تريد الحذف نهائيا ", "اشعار", MessageBoxButtons.YesNoCancel);
                    controle = new Controle();
                    if (result==DialogResult.Yes)
                    {
                        query = "select CUSTOMER_ID FROM CUSTOMERS  WHERE  CUSTOMER_NAME = N'" + name.Text + "' and  PHONE = '" + phone.Text + "'  ";
                        controle.open(query);
                        scalar = controle.execscalar();
                        int ID_CU = Convert.ToInt32(scalar);
                        controle.close();
                        query = "select INVOICE_ID FROM INVOICES  WHERE  CUSTOMER_ID = '"+ID_CU+"' ";
                        controle.open(query);
                        scalar = controle.execscalar();
                        int ID_INV = Convert.ToInt32(scalar);
                        controle.close();
                        query = "select INVOICEDETAIL_ID FROM INVOICEDETAILS  WHERE  INVOICE_ID = '" + ID_INV + "' ";
                        controle.open(query);
                        scalar = controle.execscalar();
                        int ID_INVDE = Convert.ToInt32(scalar);
                        controle.close();
                        query = @"delete INVOICEDETAILS   where INVOICEDETAIL_ID=  "+ ID_INVDE+" " +
                            "     delete INVOICES   where INVOICE_ID=  "+ ID_INV+"      " +
                            "     delete CUSTOMERS                            " +
                            "     WHERE  CUSTOMER_ID="+ ID_CU + "   AND CUSTOMER_NAME=N'" + name.Text + "' ; ";
                    }
                    else
                    {
                        query = "update CUSTOMERS set ISDELETED=1 WHERE CUSTOMER_NAME=N'" + name.Text + "' and PHONE='" + phone.Text + "';";
                    }
                    controle.open(query);
                    controle.executerows();
                    controle.close();
                    query = @"SELECT * FROM CUSTOMERS";
                    updata(query);
                    MessageBox.Show("تمت العملية بنجاج", "اشعار", MessageBoxButtons.OK);
                    name.Text = phone.Text = "";
                }
                else
                    MessageBox.Show("الزبون غير موجود بالفعل او تم حذفه مسبقاً", "اشعار", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("يوجد حقل فارغ او ان رقم الهاتف لايتكون من 10 ارقام", "اشعار", MessageBoxButtons.OK);
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if ( name.Text != "" & phone.Text != "" & phone.Text.Length == 10)
            {
                string query = "SELECT COUNT(*) FROM CUSTOMERS WHERE  CUSTOMER_NAME=N'" + name.Text+ "' and  PHONE = '"+ phone.Text + "' ";
                controle = new Controle();
                controle.open(query);
                object scalar = controle.execscalar();
                controle.close();
                int bitValueResult = (scalar != null) ? Convert.ToInt32(scalar) : -1;
                bool value = false;
                if (bitValueResult == 0)
                {
                    value = false;
                }
                else if (bitValueResult >= 1)
                {
                    query = @"UPDATE CUSTOMERS 
                            SET ISDELETED = 0
                            WHERE CUSTOMER_NAME=N'" + name.Text+ "' and  PHONE = '"+ phone.Text + "' and ISDELETED = 1";
                    controle.open(query);
                    int rows = controle.executerows();
                    controle.close();
                    if (rows >= 1)
                    {
                        query = @"SELECT * FROM CUSTOMERS";
                        updata(query);
                        MessageBox.Show("تمت استعاد الزبون", "اشعار", MessageBoxButtons.OK);
                        return;
                    }
                    value = true;
                }
                if (value)
                {
                    MessageBox.Show("الزبون موجود بالفعل", "اشعار", MessageBoxButtons.OK);
                }
                else
                {
                    query = @"INSERT INTO CUSTOMERS(CUSTOMER_NAME,PHONE)  VALUES
                        ( N'" + name.Text + "','" + phone.Text + "');";

                    controle.open(query);
                    controle.executerows();
                    controle.close();
                    query = @"SELECT * FROM CUSTOMERS";
                    updata(query);
                    MessageBox.Show("تمت العملية بنجاح", "اشعار", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("يوجد حقل فارغ او ان رقم الهاتف لايتكون من 10 ارقام", "اشعار", MessageBoxButtons.OK);
            }
        }

        public void InitializedataGridView()
        {
            if (dataGridView == null)
            {
                dataGridView = new DataGridView();
                dataGridView.Dock = DockStyle.Bottom;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.BackgroundColor = Color.White;
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                this.Height += 150;
                this.Controls.Add(dataGridView);
                dataGridView.BringToFront();
                dataGridView.CellContentClick += new DataGridViewCellEventHandler(dataGridView_CellContentClick);
            }
        }
        public void updata(string query)
        {
            if (dataGridView != null)
            {
                controle.open(query);
                controle.dataviw(dataGridView);
                controle.close();
            }
        }


        private void viewdata_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & phone.Text != "" & phone.Text.Length == 10)
            {
                InitializedataGridView();
                string query = @"SELECT CU.CUSTOMER_ID,CU.CUSTOMER_NAME,CU.PHONE,PRO.PRODUCT_NAME,PRO.QUANTITY,INED.PRICE,CU.ISDELETED FROM CUSTOMERS CU 
                JOIN INVOICES INV ON CU.CUSTOMER_ID=INV.CUSTOMER_ID 
                JOIN INVOICEDETAILS INED ON INV.INVOICE_ID = INED.INVOICE_ID
                JOIN PRODUCTS PRO ON INED.PRODUCT_ID=PRO.PRODUCT_ID
                WHERE CU.CUSTOMER_NAME=N'" + name.Text + "' and CU.PHONE='" + phone.Text + "';";
                controle = new Controle();
                updata(query);
            }
            else
            {
                MessageBox.Show("يوجد حقل فارغ او ان رقم الهاتف لايتكون من 10 ارقام", "اشعار", MessageBoxButtons.OK);
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controle = new Controle();
            if (dataGridView.Columns[e.ColumnIndex].Name == "ISDELETED" && e.RowIndex >= 0)
            {
                string query;
                if (dataGridView[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    bool isChecked = (bool)checkBoxCell.Value;
                    int Id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["CUSTOMER_ID"].Value);
                    query = "SELECT ISDELETED FROM CUSTOMERS WHERE CUSTOMER_ID = " + Id + "";
                    controle.open(query);
                    object scalar = controle.execscalar();
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
                        result = MessageBox.Show("لا يمكن حذفه هنا، فقط استرجاعه.", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        result = MessageBox.Show("هل تريد حقا استرجاع  CUSTOMERS ?", "إشعار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK & Id >= 1)
                        {
                            query = @"update CUSTOMERS
                                 set ISDELETED = 0 WHERE CUSTOMER_ID = " + Id + "";
                            controle.open(query);
                            controle.executerows();
                            controle.close();
                            MessageBox.Show("The CUSTOMERS تم إرجاعه.", "إشعار", MessageBoxButtons.OK);
                        }
                    }
                }
                query = @"SELECT * FROM CUSTOMERS";
                updata(query);
            }
        }
        private void allcustomar_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM CUSTOMERS ;";
            InitializedataGridView();
            controle = new Controle();
            updata(query);
        }
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                // التحقق من الطول الحالي
                if (phone.Text.Length >= 10 && !char.IsControl(e.KeyChar))
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
        private void back_Click(object sender, EventArgs e)
        {
            Customer_and_Supplier customer_And_Supplier = new Customer_and_Supplier();
            customer_And_Supplier.Show();
            this.Hide();
        }
    }
}
