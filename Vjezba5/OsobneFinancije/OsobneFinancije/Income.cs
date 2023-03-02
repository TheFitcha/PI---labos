using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobneFinancije
{
    internal class Income : Transaction
    {
        public Category IncomeCategory { get; set; }
        public Income(double value, Category category) : base (value, TrType.income)
        {

        }
    }
}
