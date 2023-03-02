using MjenjacnicaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class DevizniRacun : Racun
    {
        public DevizniRacun(string iban, double stanje, Valuta valuta) : base(iban, stanje)
        {
            Valuta = valuta;
            Vrsta = VrstaRacuna.Devizni;
        }

        public override string ToString()
        {
            return $"IBAN:{IBAN}, Stanje:{Stanje}, Valuta:{Valuta.Naziv}";
        }
    }
}
