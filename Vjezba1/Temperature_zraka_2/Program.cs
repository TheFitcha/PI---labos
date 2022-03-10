using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meteoStanica = "13,2;C|286,85;K|-|14,8;C|15,1;C|287,95;K|14,2;C|13,7;C";
            string[] meteoRastavljeno = meteoStanica.Split('|');
            for(int i = 0; i<meteoRastavljeno.Length; i++)
            {
                if(meteoRastavljeno[i] == "-")
                {
                    Console.WriteLine($"{i}. ocitanje = Nije uspjelo!");
                    continue;
                }
                string[] temperatura = meteoRastavljeno[i].Split(';');
                if(temperatura[1] == "C")
                {
                    Console.WriteLine($"{i}. ocitanje = {temperatura[0]} °C");
                }
                else
                {
                    Console.WriteLine($"{i}. ocitanje = {decimal.Parse(temperatura[0]) - (decimal)275.15} °C");
                }
            }
            Console.ReadKey();
        }
    }
}
