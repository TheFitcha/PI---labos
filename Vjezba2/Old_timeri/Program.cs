using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_timeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> listaVozila = new List<Vozilo>();
            string izbor;
            do
            {
                Console.WriteLine("1. Dodavanje vozila\n2. Ispis vozila\n3. Izlaz\n>>");
                izbor = Console.ReadLine();
                switch (izbor)
                {
                    case "1":
                        Console.WriteLine("Unesite naziv vozila: ");
                        string unos = Console.ReadLine();
                        Console.WriteLine("Odaberite tip vozila (a - automobil / m - motocikl): ");
                        string vrsta = Console.ReadLine();
                        if(vrsta == "a")
                        {
                            listaVozila.Add(new Automobil(unos));
                        }
                        else if(vrsta == "m")
                        {
                            listaVozila.Add(new Motocikl(unos));
                        }
                        else
                        {
                            Console.WriteLine("Neispravan unos!");
                        }
                        break;
                    case "2":
                        foreach(Vozilo vozilo in listaVozila)
                        {
                            Console.WriteLine($"Naziv vozila: {vozilo.naziv}\nVrsta vozila: {vozilo.tipVozila}\n------------------");
                        }
                        break;
                    default:
                        Console.WriteLine("Neispravan odabir!");
                        break;
                }
            } while (izbor != "3");
        }
    }
}
