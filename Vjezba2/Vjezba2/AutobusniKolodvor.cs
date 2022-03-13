using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2
{
    internal class AutobusniKolodvor
    {
        private List<Linija> linije;
        public AutobusniKolodvor()
        {
            linije = new List<Linija>
            {
                new Linija("Varazdin", "Zagreb", 80),
                new Linija("Varazdin", "Cakovec", 20),
                new Linija("Varazdin", "Slavonski Brod", 240),
                new Linija("Varazdin", "Krapina", 40),
                new Linija("Varazdin", "Novi Marof", 22),
                new Linija("Varazdin", "Koprivnica", 45),
                new Linija("Varazdin", "Virovitica", 100),
                new Linija("Varazdin", "Osijek", 220)
            };
        }

        private double IzracunajCijenu(int udaljenost, string tipKarte)
        {
            switch (tipKarte)
            {
                case "Regularna":
                    return udaljenost * 1.5;
                case "Studentska":
                    return udaljenost * 1.2;
                case "Povratna":
                    return udaljenost * 2;
                default:
                    return -1;
            }
        }

        public void KupiKartu(string polaziste, string odrediste, string tipKarte)
        {
            int udaljenost = 0;
            foreach (Linija l in linije)
            {
                if (l.Polaziste.Contains(polaziste) && l.Odrediste.Contains(odrediste))
                {
                    udaljenost = l.Udaljenost;
                    break;
                }
            }
            if (udaljenost == 0)
            {
                Console.WriteLine("Ne postoji takva linija!");
                return;
            }
            double cijena = IzracunajCijenu(udaljenost, tipKarte);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Cijena za kartu tipa {tipKarte}, na relaciji {polaziste} - {odrediste} iznosi {cijena} kn!");
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
