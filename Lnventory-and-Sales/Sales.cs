using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lnventory_and_Sales
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        Controle controle;
        int value1, value2;
        double price;
        string displayText1, displayText2;
        private void Sales_Load(object sender, EventArgs e)
        {
            controle = new Controle();
            string query = "SELECT CUSTOMER_ID, CUSTOMER_NAME FROM CUSTOMERS\r\nwhere ISDELETED=0";
            controle.open(query);
            controle.dataviw(null,comboBox1, "CUSTOMER_NAME", "CUSTOMER_ID");
            controle.close();
            query = "SELECT PRODUCT_ID,PRODUCT_NAME,PRICE FROM PRODUCTS\r\nwhere ISDELETED=0";
            controle.open(query);
            controle.dataviw(null, comboBox2, "PRODUCT_NAME", "PRODUCT_ID", "PRICE");
            controle.close();
            query = @"delete PRODUCT_IN_INVOIC";
            controle.open(query);
            controle.executerows();
            controle.close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBox1.SelectedItem;
                displayText1 = row["CUSTOMER_NAME"].ToString();
                value1 = Convert.ToInt32(row["CUSTOMER_ID"]);
                updateprice();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBox2.SelectedItem;
                displayText2 = row["PRODUCT_NAME"].ToString();
                value2 = Convert.ToInt32(row["PRODUCT_ID"]);
                price = Convert.ToDouble(row["PRICE"]);
                updateprice();
            }
        }
        private void add_cus_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Show();
            this.Hide();
        }
        private void addpro_Click(object sender, EventArgs e)
        {
            if (Quantity.Text==""|Quantity.Text=="0")
            {
                MessageBox.Show("يوجد حقل فارغ او الكمية المطلوبة غير دقيقة", "إشعار", MessageBoxButtons.OK);
            }
            else
            {
                string query = @"UPDATE PRODUCTS
                SET QUANTITY=QUANTITY-"+Quantity.Text+
                " WHERE PRODUCT_ID="+ value2 + " AND QUANTITY>="+Quantity.Text+"";
                controle = new Controle();
                controle.open(query);
                int value = controle.executerows();
                controle.close();
                bool result = false;
                if (value == 0 | value == 1)
                {
                     result = Convert.ToBoolean(value);
                }
                if (result)
                {
                    query = @"INSERT INTO PRODUCT_IN_INVOIC VALUES
                    (" + value2 + ",N'" + displayText2 + "'," + Convert.ToInt32(Quantity.Text) + "," + Convert.ToDouble(Total_price.Text) + ");";
                    controle.open(query);
                    controle.executerows();
                    controle.close();
                    update_dataGridView1();
                }
                else
                {
                    query = "SELECT QUANTITY FROM PRODUCTS  \r\n  WHERE PRODUCT_ID=" + value2 + "";
                    controle = new Controle();
                    controle.open(query);
                    SqlDataReader reader = controle.execreader();
                    int quantity = 0;

                    if (reader.Read()) // ضروري جدًا
                    {
                        quantity = Convert.ToInt32(reader["QUANTITY"]);
                    }
                    reader.Close();
                    controle.close();
                    MessageBox.Show(" "+ quantity + " لا تتوفر الكمية المطلوبة الكمية المتوفرة ", "إشعار", MessageBoxButtons.OK);
                }
            }
        }
        public void update_dataGridView1()
        {
            string query = "SELECT * FROM PRODUCT_IN_INVOIC";
            controle=new Controle();
            controle.open(query);
            controle.dataviw(dataGridView1);
            controle.close();
            Quantity.Text = "";
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;  // السماح للارقام
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;   // السماح لازرار التحكم
                return;
            }
            e.Handled = true;    // عدم السماح لبقية المحارف     
        }

        private void Quantity_Leave(object sender, EventArgs e)
        {
            updateprice();
        }

        private void Sales_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void QuantityLable_Click(object sender, EventArgs e)
        {
            Quantity.Focus();   
        }

        private void backsales_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public void updateprice()
        {
            if (Quantity.Text != "")
            {
                string quantityValue = Quantity.Text;
                Total_price.Text = (Convert.ToDouble(Quantity.Text) * price).ToString();
            }
            else Total_price.Text = "";
        }
        private void invoice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count!=0)
            {
                string query = "SELECT sum(price)[Total price] FROM PRODUCT_IN_INVOIC";
                controle = new Controle();
                controle.open(query);
                object scalar = controle.execscalar();
                controle.close();
                query = @"INSERT INTO INVOICES (CUSTOMER_ID, TOTAL_PRICE, INVOICES_DATE) VALUES
                        (@id_cu  , @price  ,   @date   );
                        SELECT SCOPE_IDENTITY();";
                controle.open(query);
                controle.command.Parameters.AddWithValue("@id_cu", value1);
                controle.command.Parameters.AddWithValue("@price", scalar);
                controle.command.Parameters.AddWithValue("@date", DateTime.Now);
                object result = controle.execscalar(); 
                int lastInvoiceID = Convert.ToInt32(result);
                controle.close();
                query = "SELECT * FROM PRODUCT_IN_INVOIC ";
                controle = new Controle();
                controle.open(query);
                SqlDataReader reader = controle.execreader();
                int quantity = 0,id=0;
                double price = 0;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID_PRO_INV"]);
                    quantity = Convert.ToInt32(reader["QUANTITY"]);
                    price = Convert.ToDouble(reader["price"]);
                    query = @" INSERT INTO INVOICEDETAILS(INVOICE_ID, PRODUCT_ID, QUANTITY, PRICE) VALUES   
                        (  @id_inv ,  @id_pro ,  @quantity , @price  );";
                    controle.open(query);
                    controle.command.Parameters.AddWithValue("@id_inv", lastInvoiceID);
                    controle.command.Parameters.AddWithValue("@id_pro", id);
                    controle.command.Parameters.AddWithValue("@quantity", quantity);
                    controle.command.Parameters.AddWithValue("@price", price);
                    controle.executerows();
                    controle.close();
                }
                reader.Close();
                controle.close();
                Invoice invoice = new Invoice();
                invoice.name_customer = comboBox1.Text;
                invoice.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("لا يمكن طباعة فاتورة فارغة", "إشعار", MessageBoxButtons.OK);
            }
        }
    }
}
