using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Utakmica
    {
        private Reprezentacija domacin, gostujuci;
        private int goloviDomacin, goloviGostujuci;

        public Utakmica(Reprezentacija domacin, Reprezentacija gostujuci, int goloviDomacin, int goloviGostujuci)
        {
            this.domacin = domacin;
            this.gostujuci = gostujuci;
            this.goloviGostujuci = goloviGostujuci;
            this.goloviDomacin = goloviDomacin;
        }

        public string GenerirajIspis()
        {
            return $"{domacin.Oznaka} {goloviDomacin}:{goloviGostujuci} {gostujuci.Oznaka}";
        }

        public Reprezentacija Domacin
        {
            get { return domacin; }
        }

        public Reprezentacija Gostujuci
        {
            get { return gostujuci; }
        }

        public int GoloviDomacin
        {
            get { return goloviDomacin; }
        }
        public int GoloviGostujuci
        {
            get { return goloviGostujuci; }
        }

    }
}
