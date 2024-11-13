using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal partial class Product
    {
        public string Category { get; set; }
        public Product()
        {
            Category = string.Empty;
        }

        public double CalculateDiscount(double x)
        {
            return 0;
        }
    }
}
