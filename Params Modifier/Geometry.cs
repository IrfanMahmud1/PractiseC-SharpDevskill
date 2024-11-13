using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Modifier
{
    internal class Geometry
    {
        public double CalculateAverage(params double[] num)
        {
            double sum = 0;
            foreach (var i in num)
            {
                sum += i;
            }
            return sum / num.Length;
        }

        public void CalculateAverage(in int x)
        {
            Console.WriteLine(x);
        }

        public void CalculateAverage(out int x,out int y, out int z)
        {
            x = 5;
            y = 15;
            z = 25;
        }
        public void Display(ref int x)
        {
            Console.WriteLine(x);
            x = 7;
        }
    }
}
