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
using System.Xml;

namespace Lnventory_and_Sales
{
    public partial class View_invoices : Form
    {
        public View_invoices()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void View_invoices_Load(object sender, EventArgs e)
        {
            string query = @"SELECT CU.CUSTOMER_ID,CU.CUSTOMER_NAME,PRO.PRODUCT_NAME,INED.QUANTITY,INED.PRICE,SU.SUPPLIER_NAME FROM INVOICES INV
                JOIN CUSTOMERS CU ON CU.CUSTOMER_ID=INV.CUSTOMER_ID 
                JOIN INVOICEDETAILS INED ON INV.INVOICE_ID = INED.INVOICE_ID
                JOIN PRODUCTS PRO ON INED.PRODUCT_ID=PRO.PRODUCT_ID
				JOIN SUPPLIERS SU ON SU.SUPPLIER_ID=PRO.SUPPLIER_ID ";
            Controle controle = new Controle();
            controle.open(query);
            controle.dataviw(dataGridView);
            controle.close();
        }
    }
}
