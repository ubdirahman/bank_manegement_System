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

namespace bank_manegement_System
{
    public partial class transfer_display : Form
    {
        private string connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";
        public transfer_display()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trasfer trasfer = new trasfer();
            trasfer.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        private void LoadTransferTransactions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TransactionID, Username, AccountNumber, Sender, MotherName, Amount, TransactionDate, ReferenceNumber FROM TransferTransactions";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        guna2DataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading data: " + ex.Message);
                    }

                }
            }
        }

        private void transfer_display_Load(object sender, EventArgs e)
        {
            LoadTransferTransactions();
        }
    }
}