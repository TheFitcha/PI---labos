using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonteska_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> fonetska = new Dictionary<string, char>()
            {
                {"Alfa", 'A'},
                {"Bravo", 'B'},
                {"Charlie", 'C'},
                {"Delta", 'D'},
                {"Echo", 'E'},
                {"Foxtrot", 'F'},
                {"Golf", 'G'},
                {"Hotel", 'H'},
                {"India", 'I'},
                {"Juliett", 'J'},
                {"Kilo", 'K'},
                {"Lima", 'L'},
                {"Mike", 'M'},
                {"November", 'N'},
                {"Oscar", 'O'},
                {"Papa", 'P'},
                {"Quebec", 'Q'},
                {"Romeo", 'R'},
                {"Sierra", 'S'},
                {"Tango", 'T'},
                {"Uniform", 'U'},
                {"Victor", 'V'},
                {"Whiskey", 'W'},
                {"Xray", 'X'},
                {"Yankee", 'Y'},
                {"Zulu", 'Z'}
            };

            Console.WriteLine("Enter a word using phonetic alphabet:");
            string korUnos = Console.ReadLine();
            string normRijec = "";
            bool pogreska = false;
            foreach(string slovo in korUnos.Split(' '))
            {
                if (!fonetska.ContainsKey(slovo))
                {
                    Console.WriteLine("Your entry is invalid!");
                    pogreska = true;   
                    break;
                }
                normRijec += fonetska[slovo];
            }
            if (!pogreska)
            {
                Console.WriteLine($"You wrote '{normRijec}'");
            }
            Console.ReadKey();  
        }
    }
}
