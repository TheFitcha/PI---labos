using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatformaLib1
{
    internal class Film : VideoSadrzaj
    {
        public int Trajanje { get; set; }
        public Film(string naziv, string opis, int trajanje) : base(naziv, opis, VrstaSadrzaja.Film)
        {
            Trajanje = trajanje;
        }
        public override string VratiInfo()
        {
            return $"{Naziv} - {Opis} - {Trajanje} - {Vrsta}";
        }
    }
}
