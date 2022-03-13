using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Transakcija
    {
        private Racun Platitelj { get; set; }
        private Racun Primatelj { get; set; }
        private double Iznos { get; set; }
        public Transakcija(Racun platitelj, Racun primatelj, double iznos)
        {
            Platitelj = platitelj;
            Primatelj = primatelj;
            Iznos = iznos;
        }
    }
}
