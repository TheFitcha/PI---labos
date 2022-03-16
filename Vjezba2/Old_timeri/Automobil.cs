using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_timeri
{
    internal class Automobil : Vozilo
    {
        public Automobil(string naziv)
        {
            this.naziv = naziv;
            this.tipVozila = Tip.automobil;
        }
        public string Naziv
        {
            get { return this.naziv; }
        }
        public Tip TipVozila
        {
            get { return this.tipVozila; }
        }
    }
}
