using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burza
{
    internal class CryptoWallet : Wallet
    {
        public CryptoWallet(double amount, string currency) : base(amount, currency)
        {

        }
        protected override double GetRateInHRK()
        {
            return 0;
        }
    }
}
