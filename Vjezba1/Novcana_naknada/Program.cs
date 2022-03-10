using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novcana_naknada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zaposlenici = new string[9]
            {
                "Ivan Ivic:8NS",
                "Ivan Ivic:6DS",
                "Ivan Ivic:4DS",
                "Ivan Ivic:4P",
                "Pero Peric:3NS",
                "Pero Peric:5DS",
                "Pero Peric:7DS",
                "Pero Peric:4DS",
                "Pero Peric:3P"
            };

            Console.WriteLine("Unesite ime i prezime zaposlenika: ");
            string zaposlenikUnos = Console.ReadLine();

            float placa = 0;
            foreach(string s in zaposlenici)
            {
                float placaSmjena = 0;
                if (s.Contains(zaposlenikUnos))
                {
                    string[] razdvojeno = s.Split(':');
                    int brojSati = int.Parse(razdvojeno[1].Substring(0, 1));
                    string vrstaSmjene = razdvojeno[1].Substring(1);
                    placaSmjena = brojSati * 150;
                    switch (vrstaSmjene)
                    {
                        case "DS":
                            placaSmjena *= 1;
                            break;
                        case "NS":
                            placaSmjena *= (float)1.5;
                            break;
                        case "P":
                            placaSmjena *= 2;
                            break;
                    }
                }
                placa += placaSmjena;
            }
            Console.WriteLine($"Zaposleniku {zaposlenikUnos} treba isplatiti ukupno {placa} kuna!");
            Console.ReadKey();
        }
    }
}
