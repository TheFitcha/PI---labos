using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle(1,1);
            String choice = "";
            List<Triangle> triangles = new List<Triangle>();
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(newTriangle.Draw());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Main menu");
                Console.WriteLine("---------");
                Console.WriteLine("1. add triangle");
                Console.WriteLine("2. display all triangles");
                Console.WriteLine("x  exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.Write("Cathetus one = ");
                            double c1 = double.Parse(Console.ReadLine());
                            Console.Write("Cathetus two = ");
                            double c2 = double.Parse(Console.ReadLine());
                            newTriangle.CathetusOne = c1;
                            newTriangle.CathetusTwo = c2;
                            triangles.Add(newTriangle);
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            foreach (var triangle in triangles)
                            {
                                Console.WriteLine("---------------");
                                Console.WriteLine(triangle.ToString());
                                Console.WriteLine(triangle.Draw());
                                Console.WriteLine("---------------");
                                Console.WriteLine("");
                            }
                            
                            break;
                        }
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
