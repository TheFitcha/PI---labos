using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite godinu rodenja: ");
            int godinaRod = int.Parse(Console.ReadLine());
            int trenutnaGodina = DateTime.Now.Year;
            int brojPrijestupnih = 0;
            for(int i = godinaRod; i < trenutnaGodina; i++)
            {
                if(i%4 == 0 || (i%100 == 0 && i%400 == 0))
                {
                    brojPrijestupnih++; 
                }
            }
            Console.WriteLine($"Broj godina: {trenutnaGodina - godinaRod}\nBroj prijestupnih godina: {brojPrijestupnih}");
            Console.ReadKey();  
        }
    }
}
