using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Reprezentacija
    {
        private string oznaka, naziv;
        public Reprezentacija(string naziv, string oznaka)
        {
            this.oznaka = oznaka;
            this.naziv = naziv;
        }

        public string Oznaka
        {
            get { return this.oznaka; }
        }

        public string Naziv
        {
            get { return this.naziv; }
        }
    }
}
