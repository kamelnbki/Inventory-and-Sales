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
    public partial class permissions : Form
    {
        public permissions()
        {
            InitializeComponent();
        }
        public static bool deleteproduct; 
        public static bool deletecustomer;
        public static bool deletesupplier; 
        public static bool loginpermissions;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updata(checkBox1.Checked, "checkBox1");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            updata(checkBox2.Checked, "checkBox2");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updata(checkBox3.Checked, "checkBox3");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            updata(checkBox4.Checked, "checkBox4");

            if (Login.userrolr != "ADMINISTRATOR"& loginpermissions==false)
            {
                MessageBox.Show("تم تغيير الصلاحية", "إشعار", MessageBoxButtons.OK);
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
                
                return;
            }

        }

        private void updata(bool bit, string namecheck)
        {
            int check;
            if (bit) { check = 1; }
            else { check = 0; }
            string query = "update CheckboxValues\r\nset IsChecked= "+ check + " \r\nwhere ItemName='"+namecheck+"';";
            Controle controle = new Controle();
            controle.open(query);
            controle.executerows();
            controle.close();
            switch (namecheck)
            {
                case "checkBox1":
                    deleteproduct = checkBox1.Checked;
                    break;
                case "checkBox2":
                    deletecustomer = checkBox2.Checked;
                    break;
                case "checkBox3":
                    deletesupplier = checkBox3.Checked;
                    break;
                case "checkBox4":
                    loginpermissions = checkBox4.Checked;
                    break;
                default:
                    break;
            }
        }

        private void permissions_Load(object sender, EventArgs e)
        {
            if (deleteproduct == true)
            {
                checkBox1.Checked = true;
            }
            if (deletecustomer == true) 
            {
                checkBox2.Checked = true;
            }
            if (deletesupplier == true)
            {
                checkBox3.Checked = true;
            }
            if(loginpermissions == true) 
            {
                checkBox4.Checked = true;
            }
        }
    }
}
