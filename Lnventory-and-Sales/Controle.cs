using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Lnventory_and_Sales
{
    internal class Controle
    {
        public static string connectionString = "Server = . ; Database=INVENTORY_AND_SALES_MANAGEMENT;Integrated Security=True;";
        public SqlConnection con;
        public SqlCommand command;
        public string creatdata()
        {
            string connection = "Server=.;Database=master;Integrated Security=True;";
            string status = "";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string query = @"
                                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'INVENTORY_AND_SALES_MANAGEMENT')
                                BEGIN
                                    CREATE DATABASE INVENTORY_AND_SALES_MANAGEMENT;
                                    SELECT 'Created' AS Status;
                                END
                                ELSE
                                BEGIN
                                    SELECT 'Exists' AS Status;
                                END";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                   return status = (string)command.ExecuteScalar();
                }
            }

            // النتيجة النهائية:
            //if (status == "Created")
            //    Console.WriteLine("✔ تم إنشاء قاعدة البيانات الآن.");
            //else if (status == "Exists")
            //    Console.WriteLine("ℹ قاعدة البيانات موجودة مسبقًا.");

        }
        public void open(string query)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            command = new SqlCommand(query, con);
        }
        public int executerows()
        {
            return command.ExecuteNonQuery();
        }
        public SqlDataReader execreader()
        {
           return command.ExecuteReader();
        }
        public object execscalar()
        {
            return command.ExecuteScalar();
        }
        public void dataviw(DataGridView dataGridView = null, ComboBox combo = null, string column_name = "", string value_name = "", string price = "")
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataGridView != null)
                {
                    dataGridView.DataSource = dataTable;
                }
                else
                {
                    combo.DataSource = dataTable;
                    combo.DisplayMember = column_name;
                    combo.ValueMember = value_name;
                    combo.ValueMember = price;
                }
            }
        }
        public void close()
        {
            con.Close();
        }
    }
}