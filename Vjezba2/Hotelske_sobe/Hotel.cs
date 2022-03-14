using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    internal class Hotel
    {
        private List<Soba> listaSoba;
        public Hotel()
        {
            listaSoba = new List<Soba>()
            {
                new Soba("10A", 3, StatusSobe.Slobodna),
                new Soba("10B", 1, StatusSobe.Rezervirana),
                new Soba("11A", 2, StatusSobe.Slobodna),
                new Soba("11B", 4, StatusSobe.Slobodna),
                new Soba("12A", 5, StatusSobe.Slobodna),
                new Soba("12B", 3, StatusSobe.Rezervirana),
                new Soba("13A", 1, StatusSobe.Slobodna),
                new Soba("13B", 2, StatusSobe.Rezervirana)
            };
        }
        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            return listaSoba.FindAll(x => x.Kapacitet >= brojOsoba && x.StatusSobe == StatusSobe.Slobodna);
        }

        public void RezervirajSobu(string oznaka)
        {
            /*int indeks = listaSoba.FindIndex(x => x.Oznaka == oznaka);
            if (listaSoba[indeks].StatusSobe != StatusSobe.Rezervirana)
            {
                listaSoba[indeks].StatusSobe = StatusSobe.Rezervirana;
            }*/
            Soba s = listaSoba.Find(x => x.Oznaka == oznaka);
            if(s.StatusSobe != StatusSobe.Rezervirana)
            {
                s.StatusSobe = StatusSobe.Rezervirana;
            }
            else
            {
                Console.WriteLine("Soba je vec rezervirana!");
            }
        }
    }
}
