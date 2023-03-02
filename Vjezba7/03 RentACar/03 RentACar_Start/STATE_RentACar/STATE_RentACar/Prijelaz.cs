using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public class Prijelaz
    {
        public StatusVozila IzvorisniStatus { get; set; }
        public Dogadaj AktivacijskiDogadaj { get; set; }
        public Prijelaz(StatusVozila status, Dogadaj dogadaj)
        {
            IzvorisniStatus = status;
            AktivacijskiDogadaj = dogadaj;
        }
    }
}
