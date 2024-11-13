using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    public class BubbleSort
    {
        public T[] Sort<T>(params T[] num) where T : INumber<T>
        {
            var temp = default(T);

            for (int i = 0; i < num.Length - 1; i++)
            {
                for(int j = 0; j < num.Length - 1;  j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }

            return num;
        }

    }
}
