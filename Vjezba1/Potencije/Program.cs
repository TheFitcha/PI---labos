using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float X, Y;
            Console.Write("Unesite prvi broj: ");
            X = float.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            Y = float.Parse(Console.ReadLine());

            float rezultat = 1;
            for(int i = 0; i < Math.Abs(Y); i++)
            {
                if (Y > 0)
                {
                    rezultat *= X;
                    Console.Write($"{X}");  
                }
                else
                {
                    rezultat *= 1 / X;
                    Console.Write($"{1 / X}");
                }
                if (i + 1 != Math.Abs(Y))
                {
                    Console.Write("*");
                }
            }
            Console.Write($" = {rezultat}");
            Console.ReadKey();
        }
    }
}
