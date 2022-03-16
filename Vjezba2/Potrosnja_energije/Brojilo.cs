using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrosnja_energije
{
    enum TipBrojila 
    { 
        Voda,
        Struja,
        Plin
    }
    internal class Brojilo
    {
        private string naziv;
        private TipBrojila tip;
        private double stanje, zadnjeOcitanje;

        public string Naziv { get { return naziv; } }
        public TipBrojila Tip { get { return tip; } }
        public Brojilo(string naziv, TipBrojila tip, double stanje, double zadnjeOcitanje)
        {
            this.naziv = naziv;
            this.tip = tip;
            this.stanje = stanje;
            this.zadnjeOcitanje = zadnjeOcitanje;
        }

        public double OcitajPotrosnju()
        {
            return stanje - zadnjeOcitanje;
        }

    }
}
