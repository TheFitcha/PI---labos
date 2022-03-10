using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite iznos KUNA u tekstualnom obliku: ");
            string unosKuna = Console.ReadLine();

            Console.Write("Upišite tečaj EUR-a (u decimalnom obliku): ");
            float eurUnos = float.Parse(Console.ReadLine());

            List<string> unosKunaList = new List<string>();
            foreach(string unos in unosKuna.Split(' '))
            {
                unosKunaList.Add(unos); 
            }
            unosKunaList.Reverse();

            int brojUnos = 0, skalar = 1;
            Dictionary<string, int> brojevi = new Dictionary<string, int>()
            {
                {"jedan", 1},
                {"dva", 2},
                {"tri", 3},
                {"cetiri", 4},
                {"pet", 5},
                {"sest", 6},
                {"sedam", 7},
                {"osam", 8},
                {"devet", 9}
            };
            foreach(string s in unosKunaList)
            {
                brojUnos += skalar * brojevi[s];
                skalar *= 10;
            }

            Console.WriteLine($"{brojUnos} KN po tečaju {eurUnos} iznosi {brojUnos / eurUnos} EUR");
            Console.ReadKey();
        }
    }
}
