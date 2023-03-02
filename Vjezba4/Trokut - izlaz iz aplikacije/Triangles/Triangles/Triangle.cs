using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Triangle
    {
        public double CathetusOne { get; set; }
        public double CathetusTwo { get; set; }
        public double Hypotenuse { get; set; }
        public double Area { get; set; }
        public Triangle(double cathetusOne, double cathetusTwo)
        {
            CathetusOne = cathetusOne;
            CathetusTwo = cathetusTwo;
            Hypotenuse = Math.Sqrt(Math.Pow(CathetusOne, 2) + Math.Pow(CathetusTwo, 2));
            Area = (CathetusOne * CathetusTwo) / 2;
        }
        public string Draw()
        {
            string returnMe = "";
            double tanAngle = Math.Tan(CathetusOne/CathetusTwo);//Boris T. : ova formula je u redu, ne trebate tu tražiti grešku.
            double line = 0;
            
            for (int i = 1; i <= CathetusOne; i++)
            {
                line = (double)i / tanAngle;
                for (int j = 0; j < line; j++)
                {
                    returnMe += "x ";
                }
                returnMe += Environment.NewLine;
            }
            return returnMe;
        }
        public override string ToString()
        {
            return $"({CathetusOne}, {CathetusTwo}, {Hypotenuse}) Area = {Area} ";
        }
    }
}
