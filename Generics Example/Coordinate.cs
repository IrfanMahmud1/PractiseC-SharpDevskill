using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    internal class Coordinate<T,M>
    {
        public T X {  get; set; }
        public M Y {  get; set; }
    }
}
