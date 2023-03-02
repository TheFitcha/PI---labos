using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobneFinancije
{
    internal class TransactionManager
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Category TransactionCategory { get; set; }
        public Envelope MoneyEnvelope { get; set; }
        public Transaction TransactionType { get; set; }
        public TransactionManager(double amount, DateTime date, Category category, Envelope envelope, Transaction transaction)
        {
            Amount = amount;
            Date = date;
            TransactionCategory = category;
            MoneyEnvelope = envelope;
            TransactionType = transaction;
        }
    }
}
