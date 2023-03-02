using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlatformaLib1
{
    public enum VrstaSadrzaja
    {
        Film, Serija
    }
    public abstract class VideoSadrzaj
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public VrstaSadrzaja Vrsta { get; set; }
        public VideoSadrzaj(string naziv, string opis, VrstaSadrzaja vrstaSadrzaja)
        {
            Naziv = naziv;
            Opis = opis;
            Vrsta = vrstaSadrzaja;
        }

        public abstract string VratiInfo();
    }

}
