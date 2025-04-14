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
    public partial class Customer_and_Supplier : Form
    {
        public Customer_and_Supplier()
        {
            InitializeComponent();
        }

        private void Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void costomer_Click(object sender, EventArgs e)
        {
            Customer_management customer_Management = new Customer_management();
            customer_Management.Show();
            this.Hide();
        }

        private void backCU_SP_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            Supplier_management supplier_Management = new Supplier_management();
            supplier_Management.Show(); 
            this.Hide();
        }

    }
}
