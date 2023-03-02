using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatformaLib1
{
    internal class Serija : VideoSadrzaj
    {
        private List<Sezona> listaSezona;
        public List<Sezona> ListaSezona
        {
            get { return listaSezona; }
            set { listaSezona = value; }
        }

        public Serija(string naziv, string opis) : base(naziv, opis, VrstaSadrzaja.Serija)
        {

        }

        public override string VratiInfo()
        {
            return $"{Naziv} - {Opis} - {Vrsta}";
        }

    }
}
