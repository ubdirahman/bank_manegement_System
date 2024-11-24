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
    public partial class trasfer : Form
    {
        public trasfer()
        {
            InitializeComponent();
        }

        private void trasfer_Load(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          

        }
       
       private string _connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";

        private void trasferbtn_Click(object sender, EventArgs e)
        {
            string username = TRASFERusernametxt.Text;
            string num_ACC = TRASFERnum_accounttxt.Text;
            string senderName = TRASFERfrom.Text; // Renamed sender to senderName
            string motherName = TRASFERmathernametxt.Text;
            decimal amount;
            if (!decimal.TryParse(TRASFERamount.Text, out amount))
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
                return;
            }
            string referenceNumber = TRASFERsaxiixtxt.Text;

            // Insert transfer details into the database
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO TransferTransactions (Username, AccountNumber, Sender, MotherName, Amount, ReferenceNumber) " +
                               "VALUES (@Username, @AccountNumber, @Sender, @MotherName, @Amount, @ReferenceNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@AccountNumber", num_ACC);
                command.Parameters.AddWithValue("@Sender", senderName);
                command.Parameters.AddWithValue("@MotherName", motherName);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                command.ExecuteNonQuery();
            }

            // Show success alert
            var alert = new CustomAlertForm("Transfer successful"); // Pass the message
            alert.Show(); // Show the alert
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            transfer_display transfer_Display = new transfer_display();
            transfer_Display.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mainmenue mainmenue = new mainmenue();
            mainmenue.Show();
        }
    }
    }

