using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public abstract class Transakcija
    {
        public int Id { get; set; }
        public double Iznos { get; set; }
        public DateTime Datum { get; set; }
        public Racun Racun { get; set; }
        public string IbanProturacuna { get; set; }
        public VrstaTransakcije Vrsta { get; set; }

        public Transakcija(Racun racun, string ibanProturacuna, double iznos)
        {
            Id = GetHashCode();
            Racun = racun;
            IbanProturacuna = ibanProturacuna;
            Iznos = iznos;
        }

        public abstract void Provedi();
    }
}
