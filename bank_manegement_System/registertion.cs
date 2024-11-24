using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace bank_manegement_System
{
    public partial class registertion : Form
    {
        private object REaddresstxt;

        public registertion()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mainmenue mainmenue = new mainmenue();
            mainmenue.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            registerdisplay registerdisplay = new registerdisplay();
            registerdisplay.Show();
        }
        public string connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";

        private bool IsUsernameUnique(string username, string phone)
        {
            string query = "SELECT COUNT(*) FROM RegistrationInformation WHERE Username = @Username";
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    count = (int)command.ExecuteScalar();
                }
            }

            return count == 0; // Returns true if the username is unique
        }
    
        private void regisgertionInformationbtn_Click(object sender, EventArgs e)
        {
            string username = REusernametxt.Text;
            string phone = REphonetxt.Text;
            string city = REcitytxt.Text;
            string address = REaddress.Text;
            string gender = REgendertxt.Text;
            string education = REeducationtxt.Text;
            if (!IsUsernameUnique(username, phone))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO RegistrationInformation (Username, Phone, City, Address, Gender, Education)" +
                    " VALUES (@Username, @Phone, @City, @Address, @Gender, @Education)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@City", city);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Education", education);

                    command.ExecuteNonQuery();
                }
            }

            // Clear the text fields after successful insertion
            REusernametxt.Text = "";
            REphonetxt.Text = "";
            REcitytxt.Text = "";
            REaddress.Text = "";
            REgendertxt.Text = "";
            REeducationtxt.Text = "";
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registertion_Load(object sender, EventArgs e)
        {

        }
    }
}
