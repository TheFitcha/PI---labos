using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burza
{
    internal class TradingAccount
    {
        public string AccountNo { get; set; }
        public List<Wallet> ListWallets;
        public TradingAccount(string accNo)
        {
            AccountNo = accNo;
            ListWallets = new List<Wallet>();
        }

        public void AddWallet(Wallet wallet)
        {
            ListWallets.Add(wallet);
        }

        public double CalculateTotalValue()
        {
            double total = 0;
            foreach (Wallet wallet in ListWallets)
            {
                total += wallet.CalculateValue();
            }
            return total;
        }
    }
}
