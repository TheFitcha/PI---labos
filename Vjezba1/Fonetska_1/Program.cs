using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonetska_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> fonetska = new Dictionary<char, string>()
            {
                {'A', "Alfa"},
                {'B', "Bravo"},
                {'C', "Charlie"},
                {'D', "Delta"},
                {'E', "Echo"},
                {'F', "Foxtrot"},
                {'G', "Golf"},
                {'H', "Hotel"},
                {'I', "India"},
                {'J', "Juliett"},
                {'K', "Kilo"},
                {'L', "Lima"},
                {'M', "Mike"},
                {'N', "November"},
                {'O', "Oscar"},
                {'P', "Papa"},
                {'Q', "Quebec"},
                {'R', "Romeo"},
                {'S', "Sierra"},
                {'T', "Tango"},
                {'U', "Uniform"},
                {'V', "Victor"},
                {'W', "Whiskey"},
                {'X', "Xray"},
                {'Y', "Yankee"},
                {'Z', "Zulu"}
            };

            Console.WriteLine("Enter a word:");
            string korUnos = Console.ReadLine();
            string fonRijec = "";
            foreach(char c in korUnos.ToArray())
            {
                fonRijec += fonetska[c] + " ";
            }
            Console.WriteLine($"Your word in phonetic alphabet looks like this: {fonRijec}");
            Console.ReadKey();
        }
    }
}
