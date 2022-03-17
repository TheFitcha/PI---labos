using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalihe_proizvoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos, naziv;
            float jedCijena;
            int kolicina;
            Skladiste skladiste = new Skladiste();
            do
            {
                Console.WriteLine("1. Dodaj proizvod na skladište\n" +
                    "2. Povećaj količinu proizvoda\n" +
                    "3. Smanji količinu proizvoda\n" +
                    "4. Ispiši stanje skladišta\n" +
                    "5. Izlaz\n" +
                    ">>");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        Console.WriteLine("Unesite naziv proizvoda:");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Unesite jedinicnu cijenu:");
                        jedCijena = float.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite kolicinu:");
                        kolicina = int.Parse(Console.ReadLine());
                        skladiste.DodajProizvod(naziv, jedCijena, kolicina);    
                        break;
                    case "2":
                        Console.WriteLine("Naziv proizvoda:");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Dodati kolicinu:");
                        kolicina = int.Parse(Console.ReadLine());
                        skladiste.PovecajKolicinuProizvoda(naziv, kolicina);
                        break;
                    case "3":
                        Console.WriteLine("Naziv proizvoda:");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Oduzeti kolicinu:");
                        kolicina = int.Parse(Console.ReadLine());
                        skladiste.OduzmiKolicinuProizvoda(naziv, kolicina);
                        break;
                    case "4":
                        skladiste.IspisiCijeloSkladiste();
                        break;
                }
            } while (unos != "5");
        }
    }
}
