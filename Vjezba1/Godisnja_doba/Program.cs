using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godisnja_doba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mjeseci = new Dictionary<string, int>()
            {
                {"sijecanj", 1},
                {"veljaca", 2},
                {"ozujak", 3},
                {"travanj", 4},
                {"svibanj", 5},
                {"lipanj", 6},
                {"srpanj", 7},
                {"kolovoz", 8},
                {"rujan", 9},
                {"listopad", 10},
                {"studeni", 11},
                {"prosinac", 12}
            };
            Console.WriteLine("Upišite proizvoljan datum u formatu \"dd mmmm\":");
            string datum = Console.ReadLine();
            string[] razdvojeniDatum = datum.Split(' ');
            DateTime unosDatum = new DateTime(DateTime.Now.Year, mjeseci[razdvojeniDatum[1]], Convert.ToInt32(razdvojeniDatum[0]));
            string rjesenje = "";
            if(unosDatum.Month <= 3)
            {
                if(unosDatum.Day < 21)
                {
                    rjesenje = "zima";
                }
                else
                {
                    rjesenje = "proljeće";
                }
            }
            else if(unosDatum.Month <= 6)
            {
                if (unosDatum.Day < 21)
                {
                    rjesenje = "proljeće";
                }
                else
                {
                    rjesenje = "ljeto";
                }
            }
            else if(unosDatum.Month <= 9)
            {
                if (unosDatum.Day < 23)
                {
                    rjesenje = "ljeto";
                }
                else
                {
                    rjesenje = "jesen";
                }
            }
            else
            {
                if (unosDatum.Day < 21)
                {
                    rjesenje = "jesen";
                }
                else
                {
                    rjesenje = "zima";
                }
            }
            Console.WriteLine($"Dan {razdvojeniDatum[0]}. {razdvojeniDatum[1]} pripada godišnjem dobu {rjesenje}.");
            Console.ReadKey();
        }
    }
}
