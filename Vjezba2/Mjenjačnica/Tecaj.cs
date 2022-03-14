using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjačnica
{
    internal class Tecaj
    {
        private string naziv;
        private float vrijednost;
        public Tecaj(string naziv, float vrijednost)
        {
            this.naziv = naziv;
            this.vrijednost = vrijednost;
        }

        public string Naziv { get { return naziv; } }
        public float Vrijednost { get { return vrijednost; } }  
    }
}
