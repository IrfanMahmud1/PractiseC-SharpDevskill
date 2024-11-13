using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class ShoppingCart
    {
        
        public List<ProductInfo> Products {get; set;}
        public ShoppingCart()
        {
            Products = new List<ProductInfo> ();
        }
        public void AddItem(ProductInfo obj)
        {
            Products.Add(obj);
        }
        public void RemoveItem(ProductInfo obj)
        {
            Products.Remove(obj);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (ProductInfo obj in Products)
            {
                total += obj.Price * obj.Quantity;
            }
            return total;

        }
    }
    internal class ProductInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
