using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class Counter
    {
        private double count;
        public void Increment(double number)
        {
            count += number;
        }
        public void Decrement(double number)
        {
            if(count > number)
            {
                count -= number;
            }
        }
        public double Getcount()
        {
            return count;
        }
    }
}
