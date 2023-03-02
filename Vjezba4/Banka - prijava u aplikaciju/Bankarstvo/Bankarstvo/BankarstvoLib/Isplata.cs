using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class Isplata : Transakcija
    {
        public Isplata(Racun platitelj, string primatelj, double iznos) : base(platitelj, primatelj, iznos)
        {
            Vrsta = VrstaTransakcije.Isplata;
        }

        public override void Provedi()
        {
            Racun.Stanje -= Iznos;
            Datum = DateTime.Now;
        }
    }
}
