using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLib1
{
    internal class Blagajna
    {
        public List<Karta> ProdaneKarte;
        public Blagajna()
        {
            ProdaneKarte = new List<Karta>();
        }

        public void ProdajKartu(Projekcija projekcija, Sjedalo sjedalo)
        {
            ProdaneKarte.Add(new Karta(projekcija, sjedalo));   
        }
    }
}
