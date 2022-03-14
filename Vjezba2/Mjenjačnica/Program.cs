using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjačnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos, odredisnaValuta, nazivValute;
            float hrkIznos, naknada, vrijednostValute;
            Mjenjacnica mjenjacnica = new Mjenjacnica();
            do
            {
                Console.Write("1. Konverzija\n2. Unos nove valute\n3. Brisanje valute\n9. Izlaz\n>> ");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        Console.WriteLine("Unesite iznos HRK: ");
                        hrkIznos = float.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite odredisnu valutu: ");
                        odredisnaValuta = Console.ReadLine();
                        Console.WriteLine("Unesite naknadu (%): ");
                        naknada = float.Parse(Console.ReadLine());
                        Potvrda p = mjenjacnica.PromijeniNovac(hrkIznos, odredisnaValuta, naknada);
                        mjenjacnica.IspisPotvrde(p);
                        break;
                    case "2":
                        Console.WriteLine("Unesite naziv valute: ");
                        nazivValute = Console.ReadLine();
                        Console.WriteLine("Unesite vrijednost valute: ");
                        vrijednostValute = float.Parse(Console.ReadLine());
                        mjenjacnica.DodajValutu(nazivValute, vrijednostValute);
                        break;
                    case "3":
                        Console.WriteLine("Unesite naziv valute za brisanje: ");
                        nazivValute = Console.ReadLine();
                        mjenjacnica.ObrisiValutu(nazivValute);
                        break;
                }
            } while (unos != "9");
        }
    }
}
