using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_manegement_System
{
    public partial class CustomAlertForm : Form
    {
        public CustomAlertForm(string message)
        {
            InitializeComponent(); // Initialize components
            alertpic.Text = message; // Set the message
          
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Timer timer = new Timer();
            timer.Interval = 2008; // Show for 2 seconds
            timer.Tick += (s, args) =>
            {
                this.Close(); // Close the form after 2 seconds
            };
            timer.Start(); // Start the timer
        }

        private void alertLabel_Click(object sender, EventArgs e)
        {

        }

        private void alertpic_Click(object sender, EventArgs e)
        {

        }
    }
    }
