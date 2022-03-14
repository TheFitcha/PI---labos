using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class GlasackaKutija
    {
        private List<Glas> glasovi = new List<Glas>();

        private bool VecGlasao(string oib)
        {
            return glasovi.Contains(glasovi.Find(x => x.OIB == oib));
        }
        public void Glasaj(string oib, string odabir)
        {
            if (!VecGlasao(odabir))
            {
                glasovi.Add(new Glas(oib, odabir));
            }
            else
            {
                Console.WriteLine("Vec ste glasali!");
            }
        }

        public void DohvatiRezultateGlasanja()
        {
            int za = glasovi.FindAll(x => x.Odabir == "Z").Count();
            int protiv = glasovi.FindAll(x => x.Odabir == "P").Count();
            int suzdrzan = glasovi.FindAll(x => x.Odabir == "S").Count();
            Console.WriteLine($"Rezultati glasanja: ZA = {za}, PROTIV = {protiv}, SUZDRŽAN = {suzdrzan}");
        }
    }
}
