using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Posudba
    {
        private string osoba;
        private Knjiga posudjenaKnjiga;
        private DateTime datum;
        public Posudba(string osoba, Knjiga knjiga)
        {
            this.osoba = osoba;
            this.posudjenaKnjiga = knjiga;
            this.datum = DateTime.Now;
        }

        public string Osoba
        {
            get { return osoba; }
        }
        public DateTime Datum
        {
            get { return datum; }
        }

        public Knjiga Knjiga
        {
            get { return posudjenaKnjiga; }
        }
    }
}
