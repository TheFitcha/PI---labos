using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Racun
    {
        private readonly string iban;
        private double stanje;

        public string IBAN
        {
            get { return iban; }
        }
        public double Stanje 
        { 
            get { return stanje; } 
            set { stanje = value; }
        }

        public Racun(string iban, double stanje)
        {
            this.iban = iban;
            this.stanje = stanje;
        }
    }
}
