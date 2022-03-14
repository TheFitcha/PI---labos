using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_2
{
    internal class Knjiga
    {
        private string naslov;
        private bool dostupno;
        private string osoba;
        public string Naslov
        {
            get { return naslov; }
        }
        public bool Dostupno
        { 
            get { return dostupno; } 
            set { dostupno = value; }
        }
        public string Osoba
        {
            get { return osoba; }
            set { osoba = value; }
        }
        public Knjiga(string naslov, bool dostupno = true, string osoba = "")
        {
            this.naslov = naslov;
            this.dostupno = dostupno;
            this.osoba = osoba;
        }

        public string DohvatiOpis()
        {
            return $"Naslov: {this.naslov}, Dostupno: {this.dostupno}, Osoba: {this.osoba}";
        }
    }
}
