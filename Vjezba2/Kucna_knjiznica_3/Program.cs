using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kucna_knjiznica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ime i prezime osobe kojoj posuđujemo knjigu:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite ISBN knjige:");
            string isbn = Console.ReadLine();
            Knjiznica k = new Knjiznica();
            Posudba p = k.PosudiKnjigu(ime, isbn);
            Console.WriteLine($"-----------------------------\n---------- POSUDBA ----------\n-----------------------------" +
                $"\nOsoba: {p.Osoba}\nNaslov knjige: {p.Knjiga.Naslov}\nDatum posudbe: {p.Datum}\n-----------------------------");
            Console.ReadKey();
        }
    }
}
