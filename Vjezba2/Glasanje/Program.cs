using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OIB, odabir;
            GlasackaKutija gk = new GlasackaKutija();
            while (true)
            {
                Console.WriteLine("Unesite OIB:");
                OIB = Console.ReadLine();
                Console.WriteLine("Unesite odabir [Z] = Za, [P] = Protiv i [S] = Suzdržan:");
                odabir = Console.ReadLine();
                gk.Glasaj(OIB, odabir);
                Console.WriteLine("Uspješno ste glasali!");
                gk.DohvatiRezultateGlasanja();
                Console.WriteLine("-------------------------------");
            }

        }
    }
}
