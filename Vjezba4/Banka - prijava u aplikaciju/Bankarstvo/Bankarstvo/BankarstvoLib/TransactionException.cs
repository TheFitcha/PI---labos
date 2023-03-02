using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class TransactionException : ApplicationException
    {
        public string Poruka { get; set; }
        public TransactionException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
