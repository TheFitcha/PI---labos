using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLib1
{
    internal class Dvorana
    {
        public string Oznaka { get; set; }
        private List<Sjedalo> listaSjedala;

        public Dvorana(string oznaka)
        {
            listaSjedala = new List<Sjedalo>(); 
            Oznaka = oznaka;
        }

        public void DodajSjedalo(Sjedalo sjedalo)
        {
            listaSjedala.Add(sjedalo);
        }
    }
}
