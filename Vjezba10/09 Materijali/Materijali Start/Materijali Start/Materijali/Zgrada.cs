using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Materijali
{
    public class Zgrada
    {
        public List<Dio> Dijelovi { get; set; }
        public List<Materijal> Materijali { get; set; }

        public Zgrada()
        {
            Materijali = new List<Materijal>();
            Dijelovi = new List<Dio>();

            Materijali.Add(new Materijal(1, "Beton", 1000, 0.5f));
            Materijali.Add(new Materijal(2, "Drvo", 100, 10f));
            Materijali.Add(new Materijal(3, "Estrih", 500, 0.8f));
            Materijali.Add(new Materijal(4, "Šljunak", 800, 0.01f));
            Materijali.Add(new Materijal(5, "Zrak", 0.1f, 0.00f));

            Dijelovi.Add(new Dio(1, "Zid1"));
            Dijelovi.Add(new Dio(2, "Zid2"));
            Dijelovi.Add(new Dio(3, "Krov1"));
        }
    }
}
