using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class Product
    {
        private const double DEFAULT_DISCOUNT = 10;
        private readonly string barcode;
        public double Price { get; set; }
        public string Name { get; set; }


        public Product(): this(string.Empty)
        {
            barcode = "";
        }
        public Product(string name):this(20,600,"Toy")
        {
            Name = name;
        }
        public Product(double discount,double price, string name)
        {
            Price = price;
            Name = name;
        }
        /// <summary>
        /// Get discount without a limit
        /// </summary>
        /// <returns></returns>
        public double CalculateDiscount()
        {
            return Price * DEFAULT_DISCOUNT / 100;
        }

        /// <summary>
        /// Get maximum discount
        /// </summary>
        /// <param name="maxDiscount">Provide a range of discount</param>
        /// <returns></returns>
        public double CalculateDiscount(int maxDiscount)
        {
            double discount = Price * DEFAULT_DISCOUNT / 100;
            return discount > maxDiscount
                 ? maxDiscount
                 : discount;
        }
    }
}
