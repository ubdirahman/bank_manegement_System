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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private string _connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name=usernametxt.Text;
            string password=passwordtxt.Text;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Assuming you want to update the user's login information
                string updateQuery = "UPDATE UserLogin SET Username = @Username, password = @Password";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Assuming you have the new username, password, and user ID
                    command.Parameters.AddWithValue("@Username",name );
                    command.Parameters.AddWithValue("@Password",password);
                  

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Show success alert
                        var alert = new CustomAlertForm("Update successful"); // Pass the message
                        alert.Show(); // Show the alert
                    }
                    else
                    {
                        // Show error alert
                        var alert = new CustomAlertForm("Update failed"); // Pass the message
                        alert.Show(); // Show the alert
                    }
                }
            }
            usernametxt.Text = " ";
            passwordtxt.Text = " ";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    }
