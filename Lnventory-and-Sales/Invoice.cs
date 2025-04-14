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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
        
        public string name_customer = "";
        private void Invoice_Load(object sender, EventArgs e)
        {
            name.Text = name_customer;
            
            string query = "SELECT * FROM PRODUCT_IN_INVOIC";
            Controle controle = new Controle();
            controle.open(query);
            controle.dataviw(dataGridView1);
            controle.close();
            
            query = "SELECT sum(price)[Total price] FROM PRODUCT_IN_INVOIC";
            
            controle.open(query);
            controle.dataviw(dataGridView2);
            controle.close();
        }
        private void completed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 basic = new Form1();
            basic.Show();
        }

        private void Invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
