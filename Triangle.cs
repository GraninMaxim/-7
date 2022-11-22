using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Triangle : Triad
    {
        public Triangle(uint number1, uint number2, uint number3) : base(number1, number2, number3)
        {

        }

        public double Area()
        {
            uint halfPer = (Number1 + Number2 + Number3) / 2;
            return Math.Sqrt(halfPer * (halfPer - Number1) * (halfPer - Number2) * (halfPer - Number3)); ;
        }

        public void Angles(out double angle1, out double angle2, out double angle3)
        {
            double cosA = (Math.Pow(Number2, 2) + Math.Pow(Number3, 2) - Math.Pow(Number1, 2)) / (2 * Number2 * Number3);
            angle1 = Math.Round(Math.Acos(cosA), 2);
            double cosB = (Math.Pow(Number2, 2) + Math.Pow(Number1, 2) - Math.Pow(Number3, 2)) / (2 * Number1 * Number2);
            angle2 = Math.Round(Math.Acos(cosB), 2);
            angle3 = 180 - (angle1 + angle2);
        }
    }
}
