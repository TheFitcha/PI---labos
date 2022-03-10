using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj jedinica: ");
            int jedinice = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj desetica: ");
            int desetice = int.Parse(Console.ReadLine());
            double rezultat = (jedinice + (desetice * 10)) * 2.1;
            Console.WriteLine($"Rezultat: {rezultat}");
            Console.ReadKey();
        }
    }
}
