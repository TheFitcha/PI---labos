using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] utakmice = new string[7]
            {
                "HRV 2:0 NIG",
                "HRV 3:0 ARG",
                "HRV 2:1 ISL",
                "HRV 1:1 DAN",
                "HRV 2:2 RUS",
                "HRV 2:1 ENG",
                "HRV 2:4 FRA"
            };

            int pobjede = 0, porazi = 0, remi = 0;

            foreach(string utm in utakmice)
            {
                string[] odvojeno = utm.Split(' ');
                string[] rezultat = odvojeno[1].Split(':');
                if(int.Parse(rezultat[0]) > int.Parse(rezultat[1]))
                {
                    pobjede++;
                }
                else if (int.Parse(rezultat[0]) == int.Parse(rezultat[1]))
                {
                    remi++;
                }
                else
                {
                    porazi++;
                }
            }
            Console.WriteLine("TABLICA REZULTATA\n---------------------------------------");
            Console.WriteLine($"Ukupno ostvarenih pobjeda: {pobjede}\nUkupno ostvarenih poraza: {porazi}\nUkupno ostvarenih remija: {remi}");
            Console.ReadKey();
        }
    }
}
