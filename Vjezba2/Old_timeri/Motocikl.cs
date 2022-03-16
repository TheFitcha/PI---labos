using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_timeri
{
    internal class Motocikl : Vozilo
    {
        public Motocikl(string naziv)
        {
            this.naziv = naziv;
            tipVozila = Tip.motocikl;
        }
        public string Naziv
        {
            get { return naziv; }
        }
        public Tip TipVozila
        {
            get { return tipVozila; }
        }
    }
}
