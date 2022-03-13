using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2
{
    internal class Linija
    {
        private string polaziste;
        private string odrediste;
        private int udaljenost;
        public string Polaziste
        {
            get { return polaziste; }
            set { polaziste = value; }
        }
        public string Odrediste
        {
            get { return odrediste; }
            set { odrediste = value; }
        }

        public int Udaljenost
        {
            get { return udaljenost; }
            set { udaljenost = value; }
        }
        public Linija(string polaziste, string odrediste, int udaljenost)
        {
            this.polaziste = polaziste;
            this.udaljenost = udaljenost;
            this.odrediste = odrediste;
        }
    }
}
