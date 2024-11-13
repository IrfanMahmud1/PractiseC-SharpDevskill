using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Geometry
    {
        private static readonly string name;
        public static int Id { get; set; }

        static Geometry()
        {
            name = "Shape";
        }
        public Geometry()
        {
            Id = 40;
        }
        public static double CalculateCircleArea(double radius)
        {
            return Id;
        }
        public static double CalculateRectangleArea(double width, double length)
        {
            return width * length;
        }
    }
}
