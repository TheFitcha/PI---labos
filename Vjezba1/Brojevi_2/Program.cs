using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, zbroj = 0;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Rezultat je ");
            for(int i = a; i<=b; i++)
            {
                if(i%c == 0)
                {
                    Console.Write(i + " ");
                    zbroj += i;
                }
            }
            Console.WriteLine($"\nSuma je {zbroj}");
            Console.ReadKey();
        }
    }
}
