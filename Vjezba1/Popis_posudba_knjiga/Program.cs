using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_posudba_knjiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naredba = String.Empty;
            List<string> dostupneKnjige = new List<string>()
            {
                "Prstenova druzina",
                "Dvije kule",
                "Rat i mir",
                "Jadnici"
            };
            List<string> posudeneKnjige = new List<string>()
            {
                "Povratak kralja",
                "Zlocin i kazna"
            };
            do
            {
                Console.WriteLine("Unesite naredbu:");
                naredba = Console.ReadLine();
                switch (naredba.Split(' ')[0])
                {
                    case "#popis":
                        Console.WriteLine("POPIS KNJIGA:\n----------------------");
                        foreach(string s in dostupneKnjige)
                        {
                            Console.WriteLine($"Naziv:{s}, Status:(dostupna)");
                        }
                        foreach(string s in posudeneKnjige)
                        {
                            Console.WriteLine($"Naziv:{s}, Status:(nedostupna)");
                        }
                        Console.WriteLine("----------------------");
                        break;
                    case "#posudi":
                        string nazivKnjige = naredba.Substring(8);
                        Console.WriteLine(nazivKnjige);
                        if (posudeneKnjige.Contains(nazivKnjige))
                        {
                            Console.WriteLine("Knjiga je vec posudena!");
                        }
                        else if (dostupneKnjige.Contains(nazivKnjige))
                        {
                            dostupneKnjige.Remove(nazivKnjige); 
                            posudeneKnjige.Add(nazivKnjige);
                            Console.WriteLine($"Knjiga {nazivKnjige} uspjeno posudena!");
                        }
                        else
                        {
                            Console.WriteLine("Unesena knjiga ne postoji!");
                        }
                        break;
                    case "#exit":
                        break;
                    default:
                        Console.WriteLine("Neispravan unos!");
                        break;
                }
            } while (naredba != "#exit");
            Console.ReadKey();
        }
    }
}
