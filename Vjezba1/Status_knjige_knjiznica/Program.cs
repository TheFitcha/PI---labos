using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status_knjige_knjiznica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> knjige = new List<string>()
            {
                "Prstenova druzina;Dostupna",
                "Dvije kule;Dostupna",
                "Povratak kralja;Na posudbi",
                "Rat i mir;Dostupna",
                "Zlocin i kazna;Na posudbi",
                "Jadnici;Dostupna"
            };
            string naredba = String.Empty;
            do
            {
                Console.WriteLine("Unesite naredbu: ");
                naredba = Console.ReadLine();
                if(naredba.Split(' ')[0] == "#status")
                {
                    bool postoji = false;
                    foreach(string knjiga in knjige)
                    {
                        string naziv = naredba.Substring(8);
                        if (knjiga.Contains(naziv))
                        {
                            postoji = true;
                            if(knjiga.Split(';')[1] == "Dostupna")
                            {
                                Console.WriteLine($"Knjiga {naziv} je dostupna za posudbu!");
                            }
                            else
                            {
                                Console.WriteLine($"Knjiga {naziv} je vec posudena!");
                            }
                        }
                    }
                    if (!postoji)
                    {
                        Console.WriteLine("U vasoj knjiznici ne postoji knjiga s tim nazivom!");
                    }
                }
                Console.WriteLine("---------------------------------");
            } while (naredba != "#exit");
            Console.ReadKey();
        }
    }
}
