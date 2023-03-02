using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobneFinancije
{
    internal class Expense : Transaction
    {
        public Category ExpenseCategory { get; set; }
        public Expense(double value, Category category) : base(value, TrType.expense)
        {

        }
    }
}
