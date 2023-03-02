using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobneFinancije
{
    public enum TrType
    {
        income, expense
    }
    public abstract class Transaction
    {
        public double Value { get; set; }
        public TrType Type { get; set; }
        public Transaction(double value, TrType type)
        {
            Value = value;
            Type = type;
        }
    }
}
