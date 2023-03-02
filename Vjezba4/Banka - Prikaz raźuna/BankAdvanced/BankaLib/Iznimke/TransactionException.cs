using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    public class TransactionException : BankException
    {
        public TransactionException(string poruku)
            :base(poruku)
        {

        }
    }
}
