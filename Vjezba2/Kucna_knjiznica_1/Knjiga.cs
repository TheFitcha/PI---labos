using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_1
{
    enum Status
    {
        Dostupno,
        NaPosudbi
    }
    internal class Knjiga
    {
        private string isbn, naslov;
        private Status status;
        public Knjiga(string isbn, string naslov, Status status)
        {
            this.isbn = isbn;
            this.naslov = naslov;
            this.status = status;
        }
        public string ISBN
        {
            get { return isbn; }
        }
        public string Naslov
        {
            get { return naslov; }
        }
        public Status StatusKnjige
        {
            get { return status; }
            set { status = value; }
        }
    }
}
