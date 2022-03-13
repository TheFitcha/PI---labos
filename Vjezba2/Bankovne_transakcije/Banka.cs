using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Banka
    {
        private List<Racun> racuni;
        public Banka()
        {
            racuni = new List<Racun>
            {
                new Racun("HR11", 100000),
                new Racun("HR22", 50000),
                new Racun("HR33", 12000),
                new Racun("HR44", 36000)
            };
        }

        private Racun DohvatiRacun(string iban)
        {
            return racuni.Find(racun => racun.IBAN == iban);
        }

        public Transakcija IzvrsiPlacanje(string ibanPlatitelja, string ibanPrimatelja, double iznos)
        {
            Racun platitelj = DohvatiRacun(ibanPlatitelja);
            Racun primatelj = DohvatiRacun(ibanPrimatelja);
            platitelj.Stanje -= iznos;
            primatelj.Stanje += iznos;
            Console.WriteLine($"POTVRDA TRANSAKCIJE:\n----------------------------\n" +
                $"Novo stanje računa {platitelj.IBAN} je {platitelj.Stanje}\nNovo stanje računa {primatelj.IBAN}" +
                $"je {primatelj.Stanje}");
            return new Transakcija(platitelj, primatelj, iznos);
        }

    }
}
