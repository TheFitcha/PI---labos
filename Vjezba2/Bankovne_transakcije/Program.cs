using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite IBAN platitelja:");
            string platitelj = Console.ReadLine();
            Console.WriteLine("Unesite IBAN primatelja:");
            string primatelj = Console.ReadLine();
            Console.WriteLine("Unesite iznos plaćanja:");
            double iznos = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Banka banka = new Banka();
            banka.IzvrsiPlacanje(platitelj, primatelj, iznos);
            Console.ReadKey();
        }
    }
}
