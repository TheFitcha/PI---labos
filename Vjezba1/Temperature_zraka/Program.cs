using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string glavni = "13,2|13,6|-|14,8|15,1|-|14,2|13,7";
            string rezervni = "286,45|286,85|287,25|288,05|288,35|287,95|287,45|286,95";
            string[] glavniRastavljeni = glavni.Split('|');
            string[] rezervniRastavljeni = rezervni.Split('|');
            decimal prosjek = 0;
            Console.WriteLine("U proteklih 24 sata su izmjerene sljedeće temperature:");
            for(int i = 0; i<glavniRastavljeni.Length; i++)
            {
                if(glavniRastavljeni[i] != "-")
                {
                    Console.WriteLine(glavniRastavljeni[i] + " °C");
                    prosjek += decimal.Parse(glavniRastavljeni[i]);
                }
                else
                {
                    decimal ispravak = decimal.Parse(rezervniRastavljeni[i]) - (decimal)273.15;
                    Console.WriteLine(ispravak + " °C");
                    prosjek += ispravak;
                }
            }
            Console.WriteLine($"Prosječna izmjerena temperatura je {Math.Round(prosjek / 8, 1)}!");
            Console.ReadKey();
        }
    }
}
