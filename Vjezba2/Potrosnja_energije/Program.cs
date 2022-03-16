using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potrosnja_energije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cijena potrosene energije za proteklo razdoblje:\n------------------------");
            Kuca k = new Kuca();
            foreach(Brojilo b in k.Brojila)
            {
                Console.WriteLine($"Brojilo {b.Naziv} ({b.Tip}) = {k.IzracunajIznosZaBrojilo(b)}");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine($"UKUPNO: {k.IzracunajIznosUkupno()} kn");
            Console.ReadKey();
        }
    }
}
