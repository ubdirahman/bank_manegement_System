using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bank_manegement_System
{

    public partial class ATM : Form
    {
        public string connectionString = "Data Source=DESKTOP-L4HJ1IF\\SQLEXPRESS;Initial Catalog=bank_of_management_system;Integrated Security=True;Encrypt=False";
       
        public ATM()
        {
            InitializeComponent();

        }

        private void Amonut_showlabal_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Amonut_showlabal, "fadlan meshaan waa lacagta dhigso");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(amount_withdrow, "fadlan meshaan waa lacagta labixisha");
        }
        //bank account fields with a $0 starting balance
        private Overload myaccount = new Overload(0m,"323223");
        
        public object AccountNumber { get; private set; }

        private void ATM_Load(object sender, EventArgs e)
        {
            balanceShowtzt.Text = myaccount.Balance.ToString("c");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application
                .Exit();
        }


        private void depositbtn_Click(object sender, EventArgs e)
        { // desimal amonut // to hold the amount of deposit
            decimal amount;
            string AccountNumber=AccountNumberdeposittxt.Text;
            // convet the amount to decimal
            if (decimal.TryParse(amount_deposittxt.Text, out amount))
            {
                
                if (myaccount.Balance <= amount)
                {
                    myaccount.Deposit(100.00m);
                    myaccount.InsertTransactionToDatabase(connectionString, "Deposit");// For a deposit
                    
                    // deposit the amount into the account 
                    myaccount.Deposit(amount);

                    // display the new balance 
                    amount_deposittxt.Text = myaccount.Balance.ToString("c");

                    // clear the text box
                    amount_deposittxt.Text = string.Empty;
                    balanceShowtzt.Text = myaccount.Balance.ToString("c");

                }
                else
                {
                    MessageBox.Show("Invalid Balance");
                    amount_deposittxt.Text = string.Empty;

                    AccountNumberdeposittxt.Text= string.Empty;

                }
            }
            else
            {
                // display the error message 
                MessageBox.Show("Invalid Amouny");
            }

        }

        

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            decimal amount;
            string AccountNumber=AccountNumberwithdrawtxt.Text;
            // convet the amount to decimal
            if (decimal.TryParse(amount_withdrawtxt.Text, out amount))
            {
               
                if (myaccount.Balance >= amount)
                {
                    myaccount.Withdrawl(0m);
                    myaccount.InsertTransactionToDatabase(connectionString, "Withdrawal"); // For a withdrawal
                    // withdraw the amount into the account 
                    myaccount.Withdrawl(amount);

                    // display the new balance 
                    amount_withdrawtxt.Text = myaccount.Balance.ToString("c");

                    // clear the text box
                    amount_withdrawtxt.Text = string.Empty;

                    balanceShowtzt.Text = myaccount.Balance.ToString("c");

                    var alert = new CustomAlertForm("Transfer successful"); // Pass the message
                    alert.Show(); // Show the alert

                }
                else
                {
                    MessageBox.Show("Invalid Balance");
                    amount_withdrawtxt.Text = string.Empty;
                    AccountNumberwithdrawtxt.Text = string.Empty;
                }

            }
            else
            {
                // display the error message 
                MessageBox.Show("Invalid Amouny");
            }
        
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BALANCE bALANCE = new BALANCE();
            bALANCE.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            mainmenue mainmenue = new mainmenue();
            mainmenue.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            mainmenue mainmenue = new mainmenue();
            mainmenue.Show();
        }
    }
}