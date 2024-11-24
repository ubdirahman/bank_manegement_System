using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bank_manegement_System
{
    public partial class mainmenue : Form
    {
        public String username;
        public mainmenue()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainmenue_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void datatime_MouseLeave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datatime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ATM aTM = new ATM();
            aTM.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            registertion registertion = new registertion();
            registertion.Show();
      
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ATM aTM = new ATM();
            aTM.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            trasfer trasfer = new trasfer();
            trasfer.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BALANCE bALANCE = new BALANCE();
            bALANCE.Show();
        }
    }
}
