using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predlaganje_filma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string odabir;
            StreamingServis ss = new StreamingServis();
            do
            {
                Console.WriteLine("Zelite li prijedlog filma (da/ne):");
                odabir = Console.ReadLine();
                if(odabir == "da")
                {
                    Console.WriteLine($"Predlazemo sljedeci film:\n{ss.PredloziFilm().DohvatiInfo()}\n------------------------");
                }
                else if(odabir != "ne")
                {
                    Console.WriteLine("Neispravan unos!");
                }
            } while (odabir != "ne");
        }
    }
}
