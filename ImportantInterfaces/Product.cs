using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class Product : ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        public object Clone()
        {
            return new Product{
                Name = Name,
                Description = Description,
                Price = Price,
                Category = Category
            };
        }
    }
}
