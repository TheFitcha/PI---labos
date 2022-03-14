using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Knjiga
    {
        private string isbn, naslov;
        public Knjiga(string isbn, string naslov)
        {
            this.isbn = isbn;
            this.naslov = naslov;
        }

        public string ISBN
        {
            get { return isbn; }
        }
        public string Naslov
        {
            get { return naslov; }
        }
    }
}
