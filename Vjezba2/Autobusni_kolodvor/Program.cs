using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite polaziste, odrediste i tip karte:");
            string unos = Console.ReadLine();
            AutobusniKolodvor ak = new AutobusniKolodvor();
            string[] razdvojeniUnos = unos.Split(' ');
            ak.KupiKartu(razdvojeniUnos[0], razdvojeniUnos[1], razdvojeniUnos[2]);
            Console.ReadKey();
        }
    }
}
