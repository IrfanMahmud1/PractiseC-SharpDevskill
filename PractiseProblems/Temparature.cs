using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class Temparature
    {
        public static double ToFahrenheit(double celcius)
        {
            return (celcius * 9) / 5 + 32;
        }
        public static double ToCelcius(double fahreinheit)
        {
            return (fahreinheit - 32)* 5 / 9 ;
        }
    }
}
