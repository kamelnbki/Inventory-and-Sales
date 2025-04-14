using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lnventory_and_Sales
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static public string userrolr = null, welcomename="";
        string value = null;

        private void Login_Load(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string status = controle.creatdata();
            if (status == "Created") 
            {
                string createDatabase = @"
                                        CREATE TABLE SUPPLIERS
                                        (
                                        SUPPLIER_ID INT PRIMARY KEY IDENTITY(1,1),
                                        SUPPLIER_NAME NVARCHAR (255) ,
                                        PHONE VARCHAR(30) ,
                                        ISDELETED BIT DEFAULT 0
                                        );

                                        INSERT INTO SUPPLIERS (SUPPLIER_NAME, PHONE) VALUES
                                        ('kamel', '0987654321'),
                                        ('nour',  '0912387654'),
                                        ('zead',  '0932165422');

                                        CREATE TABLE PRODUCTS
                                        (
                                        PRODUCT_ID INT PRIMARY KEY IDENTITY(1,1),
                                        PRODUCT_NAME NVARCHAR (255) ,
                                        PRICE NUMERIC(8,2) ,
                                        QUANTITY INT ,
                                        SUPPLIER_ID INT FOREIGN KEY (SUPPLIER_ID) REFERENCES SUPPLIERS ,
                                        ISDELETED BIT DEFAULT 0
                                        );

                                        INSERT INTO PRODUCTS (PRODUCT_NAME, PRICE, QUANTITY, SUPPLIER_ID) VALUES
                                        ('Laptop Pro 15', 1200.50, 10, 1),
                                        ('Wireless Mouse', 25.99, 50, 2),
                                        ('Office Chair', 150.00, 20, 3);

                                        CREATE TABLE CUSTOMERS
                                        (
                                        CUSTOMER_ID INT PRIMARY KEY IDENTITY(1,1),
                                        CUSTOMER_NAME NVARCHAR (255) ,
                                        PHONE VARCHAR(30) ,
                                        ISDELETED BIT DEFAULT 0
                                        );

                                        INSERT INTO CUSTOMERS (CUSTOMER_NAME, PHONE) VALUES
                                        ('kald', '0912345678'),
                                        ('kamel','0934144135'),
                                        ('nour', '1234567890');

                                        CREATE TABLE INVOICES
                                        (
                                        INVOICE_ID INT PRIMARY KEY IDENTITY(1,1),
                                        CUSTOMER_ID INT FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMERS,
                                        TOTAL_PRICE NUMERIC(12,2) ,
                                        INVOICES_DATE DATETIME DEFAULT GETDATE()
                                        );

                                        INSERT INTO INVOICES (CUSTOMER_ID, TOTAL_PRICE, INVOICES_DATE) VALUES
                                        (1, 150.50, '2023-10-26 10:30:00'),
                                        (2, 225.75, '2023-11-15 14:45:00'),
                                        (3, 100.00, '2023-12-05 09:15:00');

                                        CREATE TABLE INVOICEDETAILS  
                                        (
                                        INVOICEDETAIL_ID INT PRIMARY KEY IDENTITY(1,1),
                                        INVOICE_ID  INT FOREIGN KEY (INVOICE_ID) REFERENCES INVOICES,
                                        PRODUCT_ID INT FOREIGN KEY (PRODUCT_ID) REFERENCES PRODUCTS,
                                        QUANTITY INT,
                                        PRICE NUMERIC(8,2) 
                                        );

                                        INSERT INTO INVOICEDETAILS (INVOICE_ID, PRODUCT_ID, QUANTITY, PRICE) VALUES
                                        (1, 1, 2, 1200.50),  
                                        (1, 2, 1, 25.99),  
                                        (2, 3, 3, 150.00);  

                                         CREATE TABLE PRODUCT_IN_INVOIC
                                        (
                                        ID_PRO_INV INT  ,
                                        NAME_PRO NVARCHAR(255),
                                        QUANTITY INT  ,
                                        price numeric (8,2)
                                        );

                                        CREATE TABLE USERS
                                        (
                                        USER_ID INT PRIMARY KEY IDENTITY(1,1),
                                        USER_NAME NVARCHAR (255) NOT NULL,
                                        USER_PASSWORD NVARCHAR (255) NOT NULL,
                                        USER_ROLE NVARCHAR (30) NOT NULL
                                        );

                                        INSERT INTO USERS (USER_NAME, USER_PASSWORD, USER_ROLE) VALUES
                                        ('kamel', '123', 'ADMINISTRATOR'),
                                        ('kald', '123', 'EMPLOYEE');

                                        CREATE TABLE CheckboxValues (
                                            ID INT PRIMARY KEY IDENTITY(1,1),
                                            ItemName NVARCHAR(255),          
                                            IsChecked BIT                   
                                        );

                                        insert into CheckboxValues
                                        values ('checkBox1',0),
                                        ('checkBox2',0),
                                        ('checkBox3',0),
                                        ('checkBox4',0);
                  ";
                controle.open(createDatabase);
                controle.executerows();
                controle.close();
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (username.Text != "" & password.Text != "")
            {
                string query = "SELECT USER_ROLE FROM USERS WHERE USER_NAME = @NAME AND USER_PASSWORD=@PASSWORD;";
                

                using (SqlConnection connection = new SqlConnection(Controle.connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", username.Text);
                        command.Parameters.AddWithValue("@PASSWORD", password.Text);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // يقرأ الصف التالي (في هذه الحالة، نتوقع صفًا واحدًا)
                            {
                                userrolr = reader["USER_ROLE"].ToString(); // الوصول إلى القيمة باسم العمود
                                value = reader.GetString(0);       // الوصول إلى القيمة بفهرس العمود (يبدأ من 0)


                                welcomename=username.Text;
                                Form1 form = new Form1();
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("اسم المستخدم او كلمة السر غير صحيح اعد المحاولة ");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("يوجد حقل فارغ","إشعار",MessageBoxButtons.OK);
            }
        }

        private void labeluser_Click(object sender, EventArgs e)
        {
            username.Focus();
        }

        private void labelpassword_Click(object sender, EventArgs e)
        {
            password.Focus();
        }

        
    }
}
