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
    public partial class registerdisplay : Form
    {
        public registerdisplay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            registertion registertion = new registertion();
            registertion.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";

        private void registerdisplay_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM RegistrationInformation"; // Query to select all columns from TransferTransactions
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Rename the columns for better readability
                dataTable.Columns["Username"].ColumnName = "User Name";
                dataTable.Columns["Phone"].ColumnName = "Phone Number";
                dataTable.Columns["City"].ColumnName = "City";
                dataTable.Columns["Address"].ColumnName = "Email Address";
                dataTable.Columns["Gender"].ColumnName = "Gender";
                dataTable.Columns["Education"].ColumnName = "Education";

                // Display the data in a DataGridView
                guna2DataGridView1.DataSource = dataTable;
            }
        
}
    }
}
