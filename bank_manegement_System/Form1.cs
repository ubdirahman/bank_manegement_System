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

namespace bank_manegement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showeyes_Click(object sender, EventArgs e)
        {
            showeyes.Hide();
           passwordtxt.UseSystemPasswordChar = false;
           closeeyes.Show();
        }

        private void closeeyes_Click(object sender, EventArgs e)
        {
            closeeyes.Hide();
            passwordtxt.UseSystemPasswordChar = true;
            showeyes.Show();
        }

        private void showeyes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(showeyes, "show");
        }

        private void closeeyes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closeeyes, "close");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     
private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            string connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM UserLogin WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Login successful
                        mainmenue mainmenue = new mainmenue();
                        mainmenue.Show();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
        }
    }
}
