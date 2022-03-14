using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjačnica
{
    internal class Mjenjacnica
    {
        private TecajnaLista tl;
        public Mjenjacnica()
        {
            tl = new TecajnaLista();
        }

        public Potvrda PromijeniNovac(float iznosHRK, string odredisnaValuta, float naknadaPosto)
        {
            Tecaj tecaj = tl.tecajnaLista.Find(x => x.Naziv == odredisnaValuta);
            KonverterValuta konverter = new KonverterValuta();
            float iznosBezNaknade = konverter.Konvertiraj(iznosHRK, tecaj);
            float iznosNaknade = iznosBezNaknade * (naknadaPosto/100);
            return new Potvrda(iznosHRK, tecaj, iznosBezNaknade, naknadaPosto, iznosNaknade, iznosBezNaknade - iznosNaknade);
        }

        public void IspisPotvrde(Potvrda potvrda)
        {
            Console.WriteLine($"MJENJAČNICA\n---------------\nDatum: {potvrda.datum}\nIznos za promjenu: {potvrda.kuna}" +
                $"\nPo tečaju: {potvrda.tecajVrijednost}\nIznosi: {potvrda.konvertirano}\nNaknada: {potvrda.postoNaknada} ({potvrda.iznosNaknade} {potvrda.valuta})\n" +
                $"---------------\nZa isplatiti: {potvrda.isplata} {potvrda.valuta}");
        }

        public void DodajValutu(string naziv, float vrijednost)
        {
            tl.DodajTecaj(naziv, vrijednost);   
        }
        public void ObrisiValutu(string naziv)
        {
            tl.UkloniTecaj(naziv);
        }
    }
}
