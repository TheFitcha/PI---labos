using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    public class BankException : ApplicationException
    {
        public string Poruka { get; set; }

        public BankException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
