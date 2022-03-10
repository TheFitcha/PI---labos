using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometne_utakmice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] utakmice = new string[6]
            {
                "ARG 1:1 ISL",
                "HRV 2:0 NIG",
                "ARG 0:3 HRV",
                "NIG 2:0 ISL",
                "NIG 1:2 ARG",
                "ISL 1:2 HRV"
            };

            Console.WriteLine("TABLICA REZULTATA\n------------------");
            Console.WriteLine("Upišite oznaku reprezentacije: ");    
            string oznakaRep = Console.ReadLine();

            Console.WriteLine($"Utakmice reprezentacije {oznakaRep}:\n------------------");
            foreach(string s in utakmice)
            {
                if (s.Contains(oznakaRep))
                {
                    if (!s.StartsWith(oznakaRep))
                    {
                        string[] rezultat = s.Split(' ');
                        string pomocni = rezultat[0];
                        rezultat[0] = rezultat[2];
                        rezultat[2] = pomocni;
                        Console.WriteLine(rezultat[0] + " " + rezultat[1] + " " + rezultat[2]);
                    }
                    else
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
