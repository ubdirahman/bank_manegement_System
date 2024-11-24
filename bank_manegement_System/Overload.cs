using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_manegement_System
{
    internal class Overload
    {
        // Backing fields
        private decimal _balance;
        public string AccountNumber { get; private set; } // AccountNumber property

        // Parameterized constructor
        public Overload(decimal startingBalance, string accountNumber)
        {
            _balance = startingBalance;
            AccountNumber = accountNumber; // Initialize AccountNumber
        }

        // Balance property (read-only)
        public decimal Balance
        {
            get { return _balance; }
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        // Method to withdraw money
        public void Withdrawl(decimal amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        // Method to insert transaction into the database
        public void InsertTransactionToDatabase(string connectionString, string transactionType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Transactionswithdrawanddeposit(AccountNumber, Amount, TransactionDate, TransactionType) VALUES (@AccountNumber, @Amount, @TransactionDate, @TransactionType)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AccountNumber", AccountNumber); // Use the AccountNumber property
                command.Parameters.AddWithValue("@Amount", _balance);
                command.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                command.Parameters.AddWithValue("@TransactionType", transactionType);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    
}
}