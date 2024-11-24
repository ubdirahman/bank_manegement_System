using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_manegement_System
{
    internal class Transaction
    {
      
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        // Constructor
        public Transaction(int transactionId, string transactionType, decimal amount, DateTime transactionDate)
        {
            TransactionId = transactionId;
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
        }

    
    }

  
}
