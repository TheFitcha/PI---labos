using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godina, mjesec;
            Console.Write("Godina: ");
            godina = int.Parse(Console.ReadLine());
            Console.Write("Mjesec: ");
            mjesec = int.Parse(Console.ReadLine()); 
            int brojMjeseci = mjesec + (DateTime.Now.Year - godina)*12 - (12 - DateTime.Now.Month);
            int brojDana = brojMjeseci * 30;
            Console.WriteLine($"{brojMjeseci} mjeseci\n{brojDana} dana");
            Console.ReadKey();
        }
    }
}
