using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaLib.Iznimke;

namespace BankaLib
{
    public class TransactionException : BankaException
    {
        public TransactionException(string poruka) : base(poruka)
        {
            
        }
    }
}
