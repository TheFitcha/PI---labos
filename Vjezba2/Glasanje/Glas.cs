using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Glas
    {
        private string oib;
        private string odabir;

        public string OIB
        {
            get { return oib; }
        }

        public string Odabir
        {
            get { return odabir; }
        }

        public Glas(string oib, string glas)
        {
            this.odabir = glas;
            this.oib = oib;
        }
    }
}
