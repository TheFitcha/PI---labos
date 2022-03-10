using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik_sortiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gradovi = new List<string>();
            int izbor;
            do
            {
                Console.Write("Odaberite opciju\n---------------\n1. Unos podataka\n2. Sortiranje\n3. Ispis\n4. Izlaz\n>> ");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        string noviUnos = "";
                        while (noviUnos != "0")
                        {
                            Console.Write("Unesite grad (0 za prekid): ");
                            noviUnos = Console.ReadLine();
                            gradovi.Add(noviUnos);
                        }
                        break;
                    case 2:
                        int sort;
                        Console.Write("Odaberite način sortiranja (0 - uzlazno, 1 - silazno): ");
                        sort = int.Parse(Console.ReadLine());
                        gradovi.Sort();
                        if (sort == 1)
                        {
                            gradovi.Reverse();
                        }
                        Console.WriteLine("Gradovi sortirani!");
                        break;
                    case 3:
                        foreach(string s in gradovi)
                        {
                            Console.WriteLine(s);
                        } 
                        break;
                    case 4:
                        Console.WriteLine("Kraj programa!");
                        break;
                    default:
                        Console.WriteLine("Neispravan unos!");
                        break;
                }
            } while (izbor != 4);
            Console.ReadKey();
        }
    }
}
