using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    enum Zanr
    {
        Komedija, Akcija, Horor
    }
    internal class Film
    {
        private string naziv;
        private Zanr zanrFilma;
        private int trajanje;
        private bool vecGledan;

        public Film(string naziv, Zanr zanrFilma, int trajanje, bool vecGledan)
        {
            this.naziv = naziv;
            this.zanrFilma = zanrFilma;
            this.trajanje = trajanje;
            this.vecGledan = vecGledan;
        }

        public string DohvatiInfo()
        {
            return $"{naziv} ({zanrFilma}, {trajanje} min)";
        }

        public bool VecGledan
        {
            get { return vecGledan; }
        }

    }
}
