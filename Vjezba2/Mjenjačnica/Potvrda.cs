using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjačnica
{
    internal class Potvrda
    {
        public DateTime datum;
        public float kuna, konvertirano, tecajVrijednost, postoNaknada, iznosNaknade, isplata;
        public string valuta;

        public Potvrda(float kuna, Tecaj tecaj, float konvertirano, float naknadaPosto, float iznosNaknade, float zaIsplatiti)
        {
            this.datum = DateTime.Now;
            this.kuna = kuna;
            this.tecajVrijednost = tecaj.Vrijednost;
            this.postoNaknada = naknadaPosto;
            this.isplata = zaIsplatiti;
            this.iznosNaknade = iznosNaknade;
            this.valuta = tecaj.Naziv;
            this.konvertirano = konvertirano;
        }

    }
}
